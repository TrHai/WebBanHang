using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBanHangDienThoai.Models;

namespace WebBanHangDienThoai.ViewModel
{
    public class GioHang
    {
        public string TenSP { get; set; }
        public int MaSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public GioHang(int MaSP)
        {
            using (QLBanHangDienThoaiEntities db = new QLBanHangDienThoaiEntities())
            {
                this.MaSP = MaSP;
                SanPham sp = db.SanPhams.Single(n => n.MaSP == MaSP);
                TenSP = sp.TenSP;
                DonGia = sp.DonGia.Value;
                ThanhTien = DonGia * SoLuong;
            }
        }
        public GioHang()
        {

        }
    }
}