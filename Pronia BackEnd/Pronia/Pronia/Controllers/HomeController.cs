using Microsoft.AspNetCore.Mvc;
using Pronia.DAL;
using Pronia.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get;  }
        public HomeController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            HomeVM home = new HomeVM
            {
                Slides = _context.Slides.ToList(),
                Summary = _context.Summary.ToList(),
                Futures = _context.Futures.ToList(),
                Products=_context.Products.Where(p=>!p.IsDeleted).ToList(),
                Categories=_context.Categories.Where(c=>!c.IsDeleted).ToList()

            };
            return View(home);
        }
    }
}
