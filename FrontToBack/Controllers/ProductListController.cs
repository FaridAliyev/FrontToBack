using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.DAL;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class ProductListController : Controller
    {
        private readonly AppDbContext _db;
        public ProductListController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.Count = _db.Products.Count();
            return View(_db.Products.Select(p=>new ProductVM { 
                Id=p.Id,
                Image=p.Image,
                Name=p.Name,
                Price=p.Price,
                Category=p.Category
            }).Take(8));
        }

        public IActionResult Load(int skip)
        {
            var model= _db.Products.Select(p => new ProductVM
            {
                Id = p.Id,
                Image = p.Image,
                Name = p.Name,
                Price = p.Price,
                Category = p.Category
            }).Skip(skip).Take(8);

            return PartialView("_ProductPartial", model);
        }
    }
}