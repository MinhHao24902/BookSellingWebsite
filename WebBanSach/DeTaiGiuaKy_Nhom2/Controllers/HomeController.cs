using DeTaiGiuaKy_Nhom2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DeTaiGiuaKy_Nhom2.Controllers
{
    public class HomeController : Controller
    {
        QuanLyBanSachEntities1 db = new QuanLyBanSachEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Page404()
        {
            return View();
        }

        public ActionResult Checkout()
        {
            return View();
        }

        public ActionResult IndexSingle()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Men()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult ThanhToan()
        {
            return View();
        }

        public ActionResult Single()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult TaiKhoan()
        {
            var taikhoan = Session["TAIKHOAN"];

            ViewBag.TaiKhoan = taikhoan;

            return PartialView("_TaiKhoanPartial");
        }
        [ChildActionOnly]
        public ActionResult HienThiDanhSach()
        {
            //Lấy danh sách các thể loại truyện
            var dstheloai = db.CHUDEs.ToList();
            ViewBag.DSTheLoai = dstheloai;

            return PartialView("_TheLoaiPartial");
        }
    }
}