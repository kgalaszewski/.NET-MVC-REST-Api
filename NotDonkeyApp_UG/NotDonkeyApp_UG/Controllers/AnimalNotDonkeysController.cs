﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GraniteHouse.Data;
using NotDonkeyApp_UG.Models;
using NotDonkeyApp_UG.Services;
using NotDonkeyApp_UG.Data;

namespace NotDonkeyApp_UG.Controllers
{
    public class AnimalNotDonkeysController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AnimalNotDonkeysController(ApplicationDbContext db)
        {
            _db = db;
        }

        #region Controller Basic Methods
        public IActionResult Index()
        {
            try
            {
                var listOfAllUsers = _db.NotDonkeys.ToList();

                return View(listOfAllUsers);
            }
            catch (Exception ex)
            {
                SetErrorDetails(ex, "An error occured during trying to reach main page");
                return RedirectToAction("ThrowErrorMessage");
            }
        }

        public IActionResult Wiki()
        {
            return View();
        }

        public IActionResult AddNewAnimal()
        {
            return View();
        }

        public IActionResult AllAnimals()
        {
            try
            {
                if (!StaticDetails.DonkeysAvailableToLike.Any())
                {
                    var listOfAllUsers = _db.NotDonkeys.ToList();

                    StaticDetails.DonkeysAvailableToLike = listOfAllUsers;

                    return View(listOfAllUsers);
                }
                else
                {
                    return View(StaticDetails.DonkeysAvailableToLike);
                }
            }
            catch (Exception ex)
            {
                SetErrorDetails(ex, "An error occured during trying to display all animals");
                return RedirectToAction("ThrowErrorMessage");
            }
        }

        public IActionResult ThrowSuperException()
        {
            SetErrorDetails(new Exception(), "Test exception");
            return RedirectToAction("ThrowErrorMessage");
        }

        public IActionResult AllAnimalsInformations()
        {
            try
            {
                OneTimeAddInformations();

                var informationsToReturn = _db.AnimalsInformations.ToList();
                if (informationsToReturn.Any())
                    return View(informationsToReturn);

                SetErrorDetails(new Exception("Woops"), "List of informations about animals is currently empty");
                return RedirectToAction("ThrowErrorMessage");
            }
            catch (Exception ex)
            {
                SetErrorDetails(ex, "An error occured during trying to display all informations about animals");
                return RedirectToAction("ThrowErrorMessage");
            }
        }

        private void OneTimeAddInformations()
        {
            if (_db.AnimalsInformations.ToList().Count == 0)
            {
                _db.AnimalsInformations.Add(new AnimalWikiInformation() { AnimalName = "donkey", Information = AnimalWikiInformations.OsiolInformation });
                _db.AnimalsInformations.Add(new AnimalWikiInformation() { AnimalName = "kon", Information = AnimalWikiInformations.KonInformation });
                _db.AnimalsInformations.Add(new AnimalWikiInformation() { AnimalName = "kot", Information = AnimalWikiInformations.KotInformation });
                _db.AnimalsInformations.Add(new AnimalWikiInformation() { AnimalName = "krab", Information = AnimalWikiInformations.KrabInformation });
                _db.AnimalsInformations.Add(new AnimalWikiInformation() { AnimalName = "niedzwiedz", Information = AnimalWikiInformations.NiedzwiedzInformation });
                _db.AnimalsInformations.Add(new AnimalWikiInformation() { AnimalName = "papuga", Information = AnimalWikiInformations.PapugaInformation });
                _db.AnimalsInformations.Add(new AnimalWikiInformation() { AnimalName = "pies", Information = AnimalWikiInformations.PiesInformation });
                _db.AnimalsInformations.Add(new AnimalWikiInformation() { AnimalName = "swinia", Information = AnimalWikiInformations.SwiniaInformation });
                _db.AnimalsInformations.Add(new AnimalWikiInformation() { AnimalName = "zyrafa", Information = AnimalWikiInformations.ZyrafaInformation });
                _db.SaveChanges();
            }
        }

        public IActionResult UpdateAnimal(int Id)
        {
            var info = _db.AnimalsInformations.Find(Id);
            return View(info);
        }

        public IActionResult AddAnimalToFavourites(int id)
        {
            try
            {
                var user = _db.NotDonkeys.Find(StaticDetails.CurrentUserId);
                if (user != null)
                {
                    user.AnimalsYouLike += $"{id.ToString()}.";
                    StaticDetails.DonkeysAvailableToLike.Remove(StaticDetails.DonkeysAvailableToLike.Where(x => x.Id == id).SingleOrDefault());
                    _db.SaveChanges();
                    StaticDetails.DonkeysAvailableToLike = _db.NotDonkeys.ToList();
                }
                return RedirectToAction("AllAnimals");
            }
            catch (Exception ex)
            {
                SetErrorDetails(ex, "An error occured during trying to Add animal to your favourites");
                return RedirectToAction("ThrowErrorMessage");
            }
        }

        public IActionResult PairedAnimals()
        {
            try
            {
                var user = _db.NotDonkeys.Find(StaticDetails.CurrentUserId);
                if (user != null)
                {
                    var allAnimalLikedids = AnimalService.Instance.ProceedUserIds(user.AnimalsYouLike ?? String.Empty);
                    List<AnimalNotDonkey> yourAnimalsList = new List<AnimalNotDonkey>();

                    foreach (var id in allAnimalLikedids)
                    {
                        yourAnimalsList.Add(_db.NotDonkeys.Find(id));
                    }

                    return View(yourAnimalsList);
                }

                return View(new List<AnimalNotDonkey>());
            }
            catch (Exception ex)
            {
                SetErrorDetails(ex, "An error occured during trying to get all paired animals");
                return RedirectToAction("ThrowErrorMessage");
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(int ownerPhoneNumber, string password)
        {
            try
            {
                var user = _db.NotDonkeys.FirstOrDefault(x => x.OwnerPhoneNumber == ownerPhoneNumber);

                if (user != null)
                {
                    if (user.Password == password)
                    {
                        StaticDetails.CurrentUserId = user.Id;

                        return RedirectToAction("PairedAnimals");
                    }
                }
                StaticDetails.IsUserLogged = true;
                return View();
            }
            catch (Exception ex)
            {
                SetErrorDetails(ex, "An error occured during Logging in");
                return RedirectToAction("ThrowErrorMessage");
            }
        }

        public IActionResult Create()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                SetErrorDetails(ex, "An error occured");
                return RedirectToAction("ThrowErrorMessage");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OwnerPhoneNumber,Name,Password,AnimalType,Sex,Weight,AdditionalDescription,IsDonkey,AnimalsYouLike")] AnimalNotDonkey animalNotDonkey)
        {
            try
            {
                if (ModelState.IsValid && !animalNotDonkey.IsDonkey)
                {
                    animalNotDonkey.AnimalType = AnimalService.Instance.SetAnimalType(animalNotDonkey.AnimalType);
                    _db.Add(animalNotDonkey);
                    await _db.SaveChangesAsync();
                    StaticDetails.DonkeysAvailableToLike = _db.NotDonkeys.ToList();
                    return View("Login");
                }
                return View(animalNotDonkey);
            }
            catch (Exception ex)
            {
                SetErrorDetails(ex, "Error occured during creating new animal");
                return RedirectToAction("ThrowErrorMessage");
            }
        }

        public IActionResult ThrowErrorMessage()
        {
            return View();
        }

        public IActionResult UserProfile()
        {
            if (StaticDetails.CurrentUserId > 0)
            {
                var currentUser = _db.NotDonkeys.Find(StaticDetails.CurrentUserId);
                return View(currentUser);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        #endregion

        #region Helper Methods
        private void SetErrorDetails(Exception ex, string msgToDisplay)
        {
            StaticDetails.CurrentErrorMsg = $"An error occured due to : {ex.Message}";
            StaticDetails.AdditionalErrorInfo = msgToDisplay;
        }
        #endregion
    }
}
