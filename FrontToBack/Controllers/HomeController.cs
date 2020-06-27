using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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

        public async Task<IActionResult> AddToCart(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product product = await _db.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            List<ProductCartVM> products;
            string existingCart = Request.Cookies["cart"];

            if (existingCart == null)
            {
                products = new List<ProductCartVM>();
            }
            else
            {
                products = JsonConvert.DeserializeObject<List<ProductCartVM>>(existingCart);
            }

            ProductCartVM existingProduct = products.FirstOrDefault(p => p.Id == id);

            if (existingProduct == null)
            {
                ProductCartVM newPro = new ProductCartVM
                {
                    Id = product.Id,
                    Image = product.Image,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = 1
                };
                products.Add(newPro);
            }
            else
            {
                existingProduct.Quantity++;
            }

            string cart = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("cart", cart, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Cart()
        {
            return Content(Request.Cookies["cart"]);
        }

        public IActionResult ViewCart()
        {
            return Json(Request.Cookies["cart"]);
        }

        public IActionResult DeleteFromCart(int? id)
        {
            List<ProductCartVM> products = JsonConvert.DeserializeObject<List<ProductCartVM>>(Request.Cookies["cart"]);
            if (id == null)
            {
                return NotFound();
            }
            if (products.Find(p => p.Id == id) == null)
            {
                return NotFound();
            }

            products.Remove(products.FirstOrDefault(p => p.Id == id));

            string cart = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("cart", cart, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });

            return RedirectToAction(nameof(Index));
        }
    }
}