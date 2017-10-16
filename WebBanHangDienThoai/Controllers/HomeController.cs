using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangDienThoai.Models;

namespace WebBanHangDienThoai.Controllers
{
    public class HomeController : Controller
    {
        QLBanHangDienThoaiEntities db = new QLBanHangDienThoaiEntities();
        // GET: Home
        public ActionResult Index()
        {
            var lstDTM = db.SanPhams.Where(n => n.MaLoaiSP == 1 && n.Moi == 1 && n.DaXoa==0);
            ViewBag.ListDTM = lstDTM;

            return View();
        }
        public ActionResult MenuPartial()
        {
            var lstSP = db.SanPhams;
            return PartialView(lstSP);
        }
    }
}