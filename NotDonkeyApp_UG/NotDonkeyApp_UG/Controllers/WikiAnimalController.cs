using System;
using System.Collections.Generic;
using System.Linq;
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
        public void Post(string name, string info)
        {
            var animal = new AnimalWikiInformation() { AnimalName = name, Information = info};
            _db.AnimalsInformations.Add(animal);
            _db.SaveChanges();
        }

        [HttpPut("{newInformation}/{Id}")]
        public void Put(string newInformation, int Id)
        {
            var currentAnimal = _db.AnimalsInformations.Find(Id);
            currentAnimal.Information = newInformation;
            _db.SaveChanges();
        }

        [HttpDelete("{Id}")]
        public void Delete(int Id)
        {
            var animalInformationToRemove = _db.AnimalsInformations.Find(Id);
            _db.AnimalsInformations.Remove(animalInformationToRemove);
            _db.SaveChanges();
        }
    }
}