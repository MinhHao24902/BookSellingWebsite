using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeTaiGiuaKy_Nhom2.Models
{
    public class TaiKhoanModels
    {
        public int MaKH { get; set; }
        [Required(ErrorMessage = "Họ tên không được bỏ trống")]
        [Display(Name = "Họ tên")]
        public string HoTen { get; set; }
        [Required(ErrorMessage = "Tài khoản không được bỏ trống")]
        [Display(Name = "Tài khoản")]
        public string TaiKhoan { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được bỏ trống")]
        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }
        public string MatKhau2 { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
    }
}