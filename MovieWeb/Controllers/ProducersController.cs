
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieWeb.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieWeb.Controllers
{
    public class ProducersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProducersController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View();
        }
    }
}

