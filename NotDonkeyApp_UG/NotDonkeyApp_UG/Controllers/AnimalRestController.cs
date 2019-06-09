using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using GraniteHouse.Data;
using Microsoft.AspNetCore.Mvc;
using NotDonkeyApp_UG.Data;
using NotDonkeyApp_UG.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NotDonkeyApp_UG.Controllers
{
    [Route("[controller]/")]
    [ApiController]
    public class RestAnimalController : Controller
    {
        public ApplicationDbContext _db { get; set; }

        public RestAnimalController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<AnimalNotDonkey> Get()
        {
            return _db.NotDonkeys.ToList();
        }

        [HttpPost]
        public ActionResult Post(AnimalNotDonkey animal)
        {
            try
            {
                _db.NotDonkeys.Add(animal);
                _db.SaveChanges();
                return StatusCode((int)HttpStatusCode.Created);
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.ExpectationFailed);
            }
        }

        [HttpPut("{newNumber}")]
        public ActionResult Put(int newNumber)
        {
            try
            {
                var currentAnimal = _db.NotDonkeys.Find(StaticDetails.CurrentUserId);
                currentAnimal.OwnerPhoneNumber = newNumber;
                _db.SaveChanges();
                return StatusCode((int)HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.ExpectationFailed);
            }
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            try
            {
                var animalToRemove = _db.NotDonkeys.Find(StaticDetails.CurrentUserId);
                StaticDetails.CurrentUserId = -1;
                _db.NotDonkeys.Remove(animalToRemove);
                _db.SaveChanges();
                StaticDetails.IsUserLogged = false;
                return StatusCode((int)HttpStatusCode.OK);
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.ExpectationFailed);
            }
        }
    }
}
