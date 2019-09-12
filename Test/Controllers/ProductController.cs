using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public string Welcome(string name, int numTimes = 1)
        {
            return $"Hello {name}, NumTimes is: {numTimes}";
        }

        [HttpPost]
        public ActionResult AddProduct()
        {
            return View();
        }

        public ActionResult SaveProduct([Bind(Include = "Name,Id,Description,SizeId,Price")] ProductViewModel productViewModel)
        {
            
            if (ModelState.IsValid)
            {
                db.ProductViewModels.Add(productViewModel);
                db.SaveChanges();
                return RedirectToAction("Product", "Home");
            }
            return RedirectToAction("Product", "Home");
        }

      
        public ActionResult UpdateSaveProduct(ProductViewModel productViewModel)
        {
            ProductViewModel product = db.ProductViewModels.Single(p => p.Id == productViewModel.Id);
            TryUpdateModel(productViewModel);
            db.ProductViewModels.Remove(product);
            db.ProductViewModels.Add(productViewModel);
            db.SaveChanges();
            return RedirectToAction("Product", "Home");
        }

        [HttpPost]
        public ActionResult ViewProduct()
        {
            return RedirectToAction("Product", "Home");
        }
        public class ProductContext : DbContext
        {

            public DbSet<ProductContext> Product { get; set; }
        }

        [HttpPost]
        public ActionResult DeleteProduct(int id)
        {
            ProductViewModel product = db.ProductViewModels.Find(id);
            db.ProductViewModels.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Product", "Home");
        }


        [HttpPost]
        public ActionResult UpdateProduct(int id)
        {
            ProductViewModel product = db.ProductViewModels.Find(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult DetailsProduct(int id)
        {
            ProductViewModel product = db.ProductViewModels.Find(id);
            return View(product);
        }

    }
}