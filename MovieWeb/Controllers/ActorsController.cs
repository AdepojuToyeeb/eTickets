using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieWeb.Data;
using MovieWeb.Data.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieWeb.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        // GET: /<controller>/
        public async  Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        //Get : /Actors/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}

