using ModelEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;
using ModelEF.DAO;

namespace TestUngDung.Areas.Admin.Controllers
{
    public class TaiKhoanController : Controller
    {

        public NguyenThiMaiContext db = new NguyenThiMaiContext();

        protected void SetAlert(string message, string type)
        {
            TempData["AlertMessage"] = message;
            if (type == "success")
            {
                TempData["AlertType"] = "alert-success";
            }

            else if (type == "warning")
            {
                TempData["AlertType"] = "alert-warning";
            }
            else if (type == "error")
            {
                TempData["AlertType"] = "alert-danger";
            }
        }
        public IEnumerable<TaiKhoanNguoiDung> LisWheretAll(string keysearch, int page, int pagesize)
        {
            IQueryable<TaiKhoanNguoiDung> model = db.TaiKhoanNguoiDungs;
            if (!string.IsNullOrEmpty(keysearch))
            {
                model = model.Where(x => x.Ten.Contains(keysearch));
            }
            return model.OrderBy(x => x.Ten).ToPagedList(page, pagesize);
        }       

        public ActionResult Index(int page = 1, int pagesize = 5)
        {
            var us = new UserDAO();
            var model = us.ListAll();   
            return View(model.ToPagedList(page, pagesize));
        }      

        [HttpPost]
        public ActionResult Index(string searchString, int page = 1, int pagesize = 5)
        {
            var us = new UserDAO();
            var model = us.LisWheretAll(searchString, page, pagesize);
            ViewBag.SearchString = searchString;
            return View(model);
        }      
        public ActionResult Delete(String id)
        {
            Boolean dao = new UserDAO().Detele(id);
            return RedirectToAction("Index");
        }
        
    }
}