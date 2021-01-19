using FurkanProject.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurkanProject.Controllers
{
    public class ProductController : FurkanControllerBase
    {
        // GET: Product
        [Route("Urun/{title}/{id}")]
        public ActionResult Detail(string title, int id)
        {
            var db = new FurkanDB();
            var prod = db.Products.Where(x => x.ID == id).FirstOrDefault();
            return View(prod);
        }
    }
}