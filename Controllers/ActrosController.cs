using Microsoft.AspNetCore.Mvc;
using MovieTicket.Data;
using MovieTicket.Data.Services;
using MovieTicket.Models;

namespace MovieTicket.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var allActors = _service.GetAll();
            return View(allActors);
        }
        //Get Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("ProfilePictureURL,FullName,Bio")] Actor actor)
        {
            // the condition is'nt working
            if (ModelState.IsValid)
            {
                _service.Add(actor);
                return RedirectToAction(nameof(Index));
            }
            return View(actor);
        }

        // Get Actors/Details/id
        [HttpGet]
        public IActionResult Details(int id)
        {
            var ActorDetails = _service.GetById(id);
            if (ActorDetails == null) return View("Not Found");
            return View(ActorDetails);
        }
        //Get Actors/Edit/id
        public IActionResult Edit(int id)
        {
            var ActorDetails = _service.GetById(id);
            if (ActorDetails == null) return View("Not Found");
            return View(ActorDetails);
        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id,ProfilePictureURL,FullName,Bio")] Actor newActor)
        {
            // the condition is'nt working
            if (ModelState.IsValid)
            {
                _service.Update(id, newActor);
                return RedirectToAction(nameof(Index));
            }
            return View(newActor);

        }
        //Delete Actors/Delete/id
        public IActionResult Delete(int id)
        {
            var ActorDetails = _service.GetById(id);
            if (ActorDetails == null) return View("Not Found");
            return View(ActorDetails);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var ActorDetails = _service.GetById(id);
            if (ActorDetails == null) return View("Not Found");
            _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}