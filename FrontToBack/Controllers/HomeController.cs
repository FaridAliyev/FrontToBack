using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.DAL;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            HomeVM model = new HomeVM()
            {
                Sliders = _db.Sliders,
                Content = _db.SliderContents.FirstOrDefault(),
                Categories=_db.Categories,
                Products=_db.Products
            };
            return View(model);
        }
    }
}