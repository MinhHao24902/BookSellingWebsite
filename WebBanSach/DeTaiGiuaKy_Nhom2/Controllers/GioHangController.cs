using DeTaiGiuaKy_Nhom2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeTaiGiuaKy_Nhom2.Controllers
{
    public class GioHangController : Controller
    {
        QuanLyBanSachEntities1 db = new QuanLyBanSachEntities1();
        // GET: GioHang
        public ActionResult Index()
        {
            //Lấy thông tin giỏ hàng trong Session
            //và chuyển thành dạng SanPhamModels
            var giohang = Session["GIOHANG"] as List<SanPhamModels>;

            ViewBag.GioHang = giohang;

            return View();
        }
        public ActionResult ThemVaoGio(int id)
        {
            //Lấy thông tin giỏ hàng trong Session
            //và chuyển thành dạng SanPhamModels
            var giohang = Session["GIOHANG"] as List<SanPhamModels>;

            //Nếu ko có giỏ hàng trong Session
            if (giohang == null)
            {
                //Tạo mới một giỏ hàng có dạng danh sách SanPhamModels
                giohang = new List<SanPhamModels>();
                Session["GIOHANG"] = giohang;
            }

            var timkiem = giohang.Find(x => x.MaSanPham == id);

            var tam = db.SANPHAMs.Where(x => x.MaSanPham == id).FirstOrDefault();

            if (timkiem == null)
            {
                var sanpham = new SanPhamModels();
                //Đưa thông tin từ biến tạm vào trong SanPhamModels
                sanpham.MaSanPham = tam.MaSanPham;
                sanpham.TenSanPham = tam.TenSanPham;
                sanpham.Giaban = tam.Giaban;
                sanpham.Mota = tam.Mota;
                sanpham.Anhbia = tam.Anhbia;
                sanpham.Ngaycapnhat = tam.Ngaycapnhat;
                sanpham.Soluongton = tam.Soluongton;
                sanpham.MaCD = tam.MaCD;
                sanpham.GiaKhuyenMai = (double)tam.Giaban * (1 - 0.2);// Giảm giá 20%
                sanpham.MaNCC = tam.MaNCC;
                sanpham.DaXoa = tam.DaXoa;
                sanpham.SoLuong = 1;
                sanpham.GiaTong = (double)sanpham.GiaKhuyenMai * sanpham.SoLuong;

                giohang.Add(sanpham);
            }
            else //Nếu đã có sản phẩm thì tăng số lượng lên 1
            {
                timkiem.SoLuong += 1;
                timkiem.GiaTong = (double)timkiem.GiaKhuyenMai * timkiem.SoLuong;
            }
            return RedirectToAction("Index");
        }
        public ActionResult XoaKhoiGio(int id)
        {
            var giohang = Session["GIOHANG"] as List<SanPhamModels>;

            var timkiem = giohang.Find(x => x.MaSanPham == id);

            if (timkiem != null)
            {
                giohang.RemoveAll(x => x.MaSanPham == id);
            }

            return RedirectToAction("Index");
        }
    }
}