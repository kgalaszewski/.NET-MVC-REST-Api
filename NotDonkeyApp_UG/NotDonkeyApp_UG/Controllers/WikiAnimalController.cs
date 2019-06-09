using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using GraniteHouse.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotDonkeyApp_UG.Models;

namespace NotDonkeyApp_UG.Controllers
{
    [Route("[controller]/")]
    [ApiController]
    public class WikiAnimalController : Controller
    {
        public ApplicationDbContext _db { get; set; }

        public WikiAnimalController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<AnimalWikiInformation> Get()
        {
            return _db.AnimalsInformations.ToList();
        }

        [HttpPost("{name}/{info}")]
        public ActionResult Post(string name, string info)
        {
            try
            {
                var animal = new AnimalWikiInformation() { AnimalName = name, Information = info };
                _db.AnimalsInformations.Add(animal);
                _db.SaveChanges();
                return StatusCode((int)HttpStatusCode.Created);
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.ExpectationFailed);
            }
        }

        [HttpPut("{newInformation}/{Id}")]
        public ActionResult Put(string newInformation, int Id)
        {
            try
            {
                var currentAnimal = _db.AnimalsInformations.Find(Id);
                currentAnimal.Information = newInformation;
                _db.SaveChanges();
                return StatusCode((int)HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.ExpectationFailed);
            }
        }

        [HttpDelete("{Id}")]
        public ActionResult Delete(int Id)
        {
            try
            {
                var animalInformationToRemove = _db.AnimalsInformations.Find(Id);
                _db.AnimalsInformations.Remove(animalInformationToRemove);
                _db.SaveChanges();
                return StatusCode((int)HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.ExpectationFailed);
            }
        }
    }
}