﻿using FurkanProject.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurkanProject.Controllers
{
    public class CategoryController : FurkanControllerBase
    {
        // GET: Category
        [Route("Kategori/{isim}/{id}")]

        public ActionResult Index(string isim,int id)
        {
            var db = new FurkanDB();
            var data = db.Products.Where(x => x.IsActive == true && x.CategoryID == id).ToList();
            ViewBag.category = db.Categories.Where(x => x.ID == id).FirstOrDefault();
            return View(data);
        }
    }
}