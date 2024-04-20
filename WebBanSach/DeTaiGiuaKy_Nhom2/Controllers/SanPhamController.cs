using DeTaiGiuaKy_Nhom2.Models;
using System.Linq;
using System.Web.Mvc;

namespace DeTaiGiuaKy_Nhom2.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        // Đưa tất cả sản phẩm ra màn hình
        QuanLyBanSachEntities1 db = new QuanLyBanSachEntities1();
        public ActionResult Index()
        {
            // Lấy ra danh sách các sản phẩm chưa bị xoá
            var sanpham = db.SANPHAMs.Where(sp => sp.DaXoa == false)
                .Select(sp => new SanPhamModels
                {
                    TenSanPham = sp.TenSanPham,
                    MaSanPham = sp.MaSanPham,
                    Soluongton = sp.Soluongton,
                    GiaKhuyenMai = (double)sp.Giaban * (1 - 0.2), // Giảm giá 20%
                    TheLoai = sp.CHUDE.TenChuDe,
                    Anhbia = sp.Anhbia,
                    Giaban = sp.Giaban,
                    Mota = sp.Mota,
                    Ngaycapnhat = sp.Ngaycapnhat,
                    MaCD = sp.MaCD,
                    MaNCC = sp.MaNCC,
                    TenNhaXuatBan = sp.NHACUNGCAP.TenNCC,
                    DaXoa = sp.DaXoa
                })

                .FirstOrDefault();
            // Truyền thông tin vào ViewBag
            ViewBag.SanPham = sanpham;

            return View();
        }
        public ActionResult ChiTietSanPham(int id)
        {
            //Lấy ra sản phẩm có MaSanPham = id
            var sanpham = db.SANPHAMs.Where(sp => sp.DaXoa == false && sp.MaSanPham == id)
                .Select(sp => new SanPhamModels
                {
                    TenSanPham = sp.TenSanPham,
                    MaSanPham = sp.MaSanPham,
                    Soluongton = sp.Soluongton,
                    Anhbia = sp.Anhbia,
                    Giaban = sp.Giaban,
                    GiaKhuyenMai = (double)sp.Giaban * (1 - 0.2), // Giảm giá 20%
                    Mota = sp.Mota,
                    Ngaycapnhat = sp.Ngaycapnhat,
                    MaCD = sp.MaCD,
                    TheLoai = sp.CHUDE.TenChuDe,
                    MaNCC = sp.MaNCC,
                    TenNhaXuatBan = sp.NHACUNGCAP.TenNCC,
                    DaXoa = sp.DaXoa
                })
                .FirstOrDefault();
            ViewBag.SanPham = sanpham;

            return View();
        }
        public ActionResult TatCaSanPham()
        {
            var sanpham = db.SANPHAMs.Where(sp => sp.DaXoa == false)
                .Select(sp => new SanPhamModels
                {
                    TenSanPham = sp.TenSanPham,
                    MaSanPham = sp.MaSanPham,
                    Soluongton = sp.Soluongton,
                    GiaKhuyenMai = (double)sp.Giaban * (1 - 0.2), // Giảm giá 20%
                    TheLoai = sp.CHUDE.TenChuDe,
                    Anhbia = sp.Anhbia,
                    Giaban = sp.Giaban,
                    Mota = sp.Mota,
                    Ngaycapnhat = sp.Ngaycapnhat,
                    MaCD = sp.MaCD,
                    MaNCC = sp.MaNCC,
                    TenNhaXuatBan = sp.NHACUNGCAP.TenNCC,
                    DaXoa = sp.DaXoa
                })

                .ToList();
            // Truyền thông tin vào ViewBag
            ViewBag.SanPham = sanpham;

            return View();
        }
    }
}