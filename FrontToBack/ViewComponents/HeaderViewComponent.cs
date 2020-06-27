using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public HeaderViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string cart = Request.Cookies["cart"];
            ViewBag.CartQuantity = 0;
            ViewBag.CartTotal = 0;
            if (cart!=null)
            {
                List<ProductCartVM> products = JsonConvert.DeserializeObject<List<ProductCartVM>>(cart);
                ViewBag.CartQuantity = products.Sum(p=>p.Quantity);
                ViewBag.CartTotal = products.Sum(p => p.Quantity*p.Price);
            }          
            Bio model = _db.Bios.FirstOrDefault();
            return View(await Task.FromResult(model));
        }
    }
}
