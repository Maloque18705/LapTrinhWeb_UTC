using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day08.Models
{
    [Table("HOA_DON")]
    public class HOA_DON
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Mã hóa đơn không được để trống!")]
        [StringLength(20, ErrorMessage = "Mã hóa đơn không được vượt quá 20 ký tự!")]
        public string MaHoaDon { get; set; }

        [Required(ErrorMessage = "Mã khách hàng không được để trống!")]
        [ForeignKey("KHACH_HANG")]
        public int MaKhachHang { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Ngày hóa đơn không được để trống!")]
        public DateTime NgayHoaDon { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime? NgayNhan { get; set; }

        [StringLength(100, ErrorMessage = "Họ tên khách hàng không được vượt quá 100 ký tự!")]
        public string? HoTenKhachHang { get; set; }

        [EmailAddress(ErrorMessage = "Email không hợp lệ!")]
        [StringLength(100, ErrorMessage = "Email không được vượt quá 100 ký tự!")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "Số điện thoại không hợp lệ!")]
        [StringLength(20, ErrorMessage = "Số điện thoại không được vượt quá 20 ký tự!")]
        public string? DienThoai { get; set; }

        [StringLength(200, ErrorMessage = "Địa chỉ không được vượt quá 200 ký tự!")]
        public string? DiaChi { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Tổng trị giá phải lớn hơn hoặc bằng 0!")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TongTriGia { get; set; } = 0;

        public bool TrangThai { get; set; } = true;

        // Khóa ngoại liên kết đến KHACH_HANG
        public KHACH_HANG? KHACH_HANG { get; set; }
    }
}
