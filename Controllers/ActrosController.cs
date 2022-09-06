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

        // Get Actors/Details/1
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var ActorDetails = _service.GetById(id);
            if (ActorDetails == null) return View("Empty");
            return View(ActorDetails);
        }

    }
}