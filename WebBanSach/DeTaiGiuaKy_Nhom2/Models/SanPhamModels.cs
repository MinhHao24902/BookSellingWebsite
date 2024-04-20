using System;

namespace DeTaiGiuaKy_Nhom2.Models
{
    public class SanPhamModels
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string TenNhaXuatBan { get; set; }
        public decimal? Giaban { get; set; }
        public string Mota { get; set; }
        public string Anhbia { get; set; }
        public DateTime? Ngaycapnhat { get; set; }
        public int? Soluongton { get; set; }
        public int? MaCD { get; set; }
        public int? MaNCC { get; set; }
        public bool? DaXoa { get; set; }
        public double GiaKhuyenMai { get; set; }
        public string TheLoai { get; set; }
        public int SoLuong { get; set; }
        public double GiaTong { get; set; }
    }
}