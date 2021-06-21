﻿using ModelEF.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUngDung.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var saphamdao = new SanPhamDAO();
            ViewBag.NewProducts = saphamdao.ListNewProduct(24);
            return View();
        }
    }
}