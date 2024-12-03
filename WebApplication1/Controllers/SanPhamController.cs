using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HienThiDSSP()
        {
            ConnectSanPham obj = new ConnectSanPham();
            List<SanPham> list = obj.getData();
            return View(list);
        }
    }
}