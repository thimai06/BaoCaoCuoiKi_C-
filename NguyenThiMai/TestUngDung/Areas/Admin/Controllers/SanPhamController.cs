using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModelEF.DAO;
using ModelEF.Model;
using PagedList;

namespace TestUngDung.Areas.Admin.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: Admin/SanPham
        public NguyenThiMaiContext db = new NguyenThiMaiContext();
       
        public IEnumerable<SanPham> LisWheretAll(string keysearch, int page, int pagesize)
        {
            IQueryable<SanPham> model = db.SanPhams;
            if (!string.IsNullOrEmpty(keysearch))
            {
                model = model.Where(x => x.TenSP.Contains(keysearch));
            }
            return model.OrderBy(x => x.TenSP).ToPagedList(page, pagesize);
        }
        public ActionResult Index(int page = 1, int pagesize = 5)
        {
            var sanpham = new SanPhamDAO();
            var model = sanpham.ListAll();

            return View(model.ToPagedList(page, pagesize));
        }
        [HttpPost]
        public ActionResult Index(string searchString, int page = 1, int pagesize = 5)
        {
            var sanpham = new SanPhamDAO();
            var model = sanpham.LisWheretAll(searchString, page, pagesize);
            ViewBag.SearchString = searchString;
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.LoaiSP_ID = new SelectList(db.LoaiSPs, "IDLSP", "TenLoai");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDSP,TenSP,DonGia,SoLuong,MoTa,LoaiSP_ID")] SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                var dao = new SanPhamDAO();
                if (dao.Find(sanPham.IDSP) != null)
                {
                    SetAlert("trùng mã nhập tên khác", "warning");
                    return RedirectToAction("Create");
                    //ModelState.AddModelError("", "Trùng Mã");
                }
                else
                {
                    db.SanPhams.Add(sanPham);
                    db.SaveChanges();
                    SetAlert("Thêm thành công", "success");
                    return RedirectToAction("Index");
                }

            }

            ViewBag.LoaiSP_ID = new SelectList(db.LoaiSPs, "IDLSP", "TenLoai", sanPham.LoaiSP_ID);
            return View(sanPham);
        }
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

        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            ViewBag.LoaiSP_ID = new SelectList(db.LoaiSPs, "IDLSP", "TenLoai", sanPham.LoaiSP_ID);
            return View(sanPham);
        }

        // POST: Admin/SanPhams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDSP,TenSP,DonGia,SoLuong,MoTa,LoaiSP_ID")] SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sanPham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LoaiSP_ID = new SelectList(db.LoaiSPs, "IDLSP", "TenLoai", sanPham.LoaiSP_ID);
            return View(sanPham);
        }
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }
       
        
    }
}