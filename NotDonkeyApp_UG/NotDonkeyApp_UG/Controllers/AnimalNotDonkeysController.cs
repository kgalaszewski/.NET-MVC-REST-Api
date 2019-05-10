using System;
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

        public IActionResult Index()
        {
            var listOfAllUsers = _db.NotDonkeys.ToList();

            return View(listOfAllUsers);
        }

        public IActionResult AllAnimals()
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

        public IActionResult AddAnimalToFavourites(int id)
        {
            var user = _db.NotDonkeys.Find(StaticDetails.CurrentUserId);
            if (user != null)
            {
                user.AnimalsYouLike += $"{id.ToString()}.";
                StaticDetails.DonkeysAvailableToLike.Remove(StaticDetails.DonkeysAvailableToLike[id]);
                _db.SaveChanges();
            }
            return RedirectToAction("AllAnimals");
        }

        public IActionResult PairedAnimals()
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

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(int ownerPhoneNumber, string password)
        {
            var user = _db.NotDonkeys.FirstOrDefault(x => x.OwnerPhoneNumber == ownerPhoneNumber);

            if (user.Password == password)
            {
                StaticDetails.CurrentUserId = user.Id;

                return RedirectToAction("PairedAnimals");
            }

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OwnerPhoneNumber,Name,Password,AnimalType,Sex,Weight,AdditionalDescription,IsDonkey,AnimalsYouLike")] AnimalNotDonkey animalNotDonkey)
        {
            if (ModelState.IsValid && !animalNotDonkey.IsDonkey)
            {
                animalNotDonkey.AnimalType = AnimalService.Instance.SetAnimalType(animalNotDonkey.AnimalType);
                _db.Add(animalNotDonkey);
                await _db.SaveChangesAsync();
                return View("Login");
            }
            return View(animalNotDonkey);
        }
    }
}
