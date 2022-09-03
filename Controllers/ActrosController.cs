using Microsoft.AspNetCore.Mvc;
using MovieTicket.Data;
using MovieTicket.Data.Services;

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
    }
}