using FrontToBack.DAL;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.ViewComponents
{
    public class ProductsViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public ProductsViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var model = _db.Products.Select(p => new ProductVM
            {
                Id = p.Id,
                Image = p.Image,
                Name = p.Name,
                Price = p.Price,
                Category = p.Category
            }).Take(count);

            return View(await Task.FromResult(model));
        }
    }
}
