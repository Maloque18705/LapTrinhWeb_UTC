using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day08.Models
{
    [Table("KHACH_HANG")]
    public class KHACH_HANG
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Mã khách hàng không được để trống!")]
        [StringLength(20, ErrorMessage = "Mã khách hàng không được vượt quá 20 ký tự!")]
        public string MaKhachHang { get; set; }

        [Required(ErrorMessage = "Họ tên khách hàng không được để trống!")]
        [StringLength(100, ErrorMessage = "Họ tên khách hàng không được vượt quá 100 ký tự!")]
        public string HoTenKhachHang { get; set; }

        [EmailAddress(ErrorMessage = "Email không hợp lệ!")]
        [StringLength(100, ErrorMessage = "Email không được vượt quá 100 ký tự!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống!")]
        [StringLength(100, ErrorMessage = "Mật khẩu không được vượt quá 100 ký tự!")]
        public string MatKhau { get; set; }

        [Phone(ErrorMessage = "Số điện thoại không hợp lệ!")]
        [StringLength(20, ErrorMessage = "Số điện thoại không được vượt quá 20 ký tự!")]
        public string? DienThoai { get; set; }

        [StringLength(200, ErrorMessage = "Địa chỉ không được vượt quá 200 ký tự!")]
        public string? DiaChi { get; set; }

        [DataType(DataType.Date)]
        public DateTime? NgayDangKy { get; set; } = DateTime.Now;

        public bool TrangThai { get; set; } = true;
    }
}
