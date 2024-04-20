using DeTaiGiuaKy_Nhom2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DeTaiGiuaKy_Nhom2.Controllers
{
    public class TaiKhoanController : Controller
    {
        QuanLyBanSachEntities1 db = new QuanLyBanSachEntities1();
        // GET: TaiKhoan
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(TaiKhoanModels models)
        {
            if (ModelState.IsValid) 
            {
            KHACHHANG kh = new KHACHHANG();

            kh.HoTen = models.HoTen;
            kh.MaKH = models.MaKH;
            kh.MatKhau = models.MatKhau;
            kh.NgaySinh = models.NgaySinh;
            kh.TaiKhoan = models.TaiKhoan;
            kh.DiaChi = models.DiaChi;
            kh.DienThoai = models.DienThoai;
            kh.Email = models.Email;

            db.KHACHHANGs.Add(kh);
            db.SaveChanges();
            }
            return View();
        }
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(TaiKhoanModels model)
        {
            //Kiểm tra trong database có tài khoản vừa nhập ko

            var taikhoan = db.KHACHHANGs
                .Where(x => x.TaiKhoan == model.TaiKhoan && x.MatKhau == model.MatKhau)
                .FirstOrDefault();

            //Nếu có tài khoản trong DB thì lưu vào Session rồi chuyển về trang chủ
            if (ModelState.IsValid)
            {
                if (taikhoan != null)
                {
                    Session["TAIKHOAN"] = taikhoan;
                    return RedirectToAction("Index", "SanPham");
                }

                //Còn ko thì
            }
            return View();
        }
    }
}