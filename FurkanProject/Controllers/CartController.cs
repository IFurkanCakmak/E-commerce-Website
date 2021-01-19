using FurkanProject.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurkanProject.Controllers
{
    public class CartController : FurkanControllerBase
    {
        // GET: Cart
        [HttpPost]
        public JsonResult AddProduct(int productID, int quantity)
        {
            var db = new FurkanDB();
            db.Carts.Add(new Core.Model.Entity.Cart
            {
                CreateDate = DateTime.Now,
                CreateUserID = LoginUserID,
                ProductID = productID,
                Quantity = quantity,
                UserID = LoginUserID,
            });
            var rt= db.SaveChanges();
            return Json(rt,JsonRequestBehavior.AllowGet);
        }

        [Route("Sepetim")]
        public ActionResult Index()
        {
            var db = new FurkanDB();
            var data = db.Carts.Include("Product").Where(x => x.UserID == LoginUserID).ToList();
            return View(data);
        }
        public ActionResult Delete(int id)
        {
            var db = new FurkanDB();
            var deleteitem = db.Carts.Where(x => x.ID == id).FirstOrDefault();
            db.Carts.Remove(deleteitem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}