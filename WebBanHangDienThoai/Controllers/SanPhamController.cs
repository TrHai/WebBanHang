﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebBanHangDienThoai.Models;

namespace WebBanHangDienThoai.Controllers
{
    public class SanPhamController : Controller
    {
        QLBanHangDienThoaiEntities db = new QLBanHangDienThoaiEntities();
        // GET: SanPham
        [ChildActionOnly]//để chặn người dùng ko thể Get vào partial này
        public ActionResult SanPhamStyle1Partial()
        {
            return PartialView();
        }
        [ChildActionOnly]//để chặn người dùng ko thể Get vào partial này
        public ActionResult SanPhamStyle2Partial()
        {
            return PartialView();
        }
        public ActionResult XemChiTiet(int? id)
        {
            
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadGateway);
            }
          
            SanPham sp = db.SanPhams.SingleOrDefault(n => n.MaSP == id && n.DaXoa==0);
            if(sp==null)
            {
                return HttpNotFound();
            }
            return View(sp);
        }
    }
}