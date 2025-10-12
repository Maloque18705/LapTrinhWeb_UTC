using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day08.Models
{
    [Table("SAN_PHAM")]
    public class SAN_PHAM
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Mã sản phẩm không được để trống!")]
        [StringLength(20, ErrorMessage = "Mã sản phẩm không được vượt quá 20 ký tự!")]
        public string MaSanPham { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống!")]
        [StringLength(200, ErrorMessage = "Tên sản phẩm không được vượt quá 200 ký tự!")]
        public string TenSanPham { get; set; }

        [StringLength(255, ErrorMessage = "Tên tệp hình ảnh không được vượt quá 255 ký tự!")]
        public string? HinhAnh { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn hoặc bằng 0!")]
        public int SoLuong { get; set; } = 0;

        [Required(ErrorMessage = "Đơn giá không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Đơn giá phải lớn hơn hoặc bằng 0!")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal DonGia { get; set; }

        [Required(ErrorMessage = "Mã loại sản phẩm không được để trống!")]
        [ForeignKey("LOAI_SAN_PHAM")]
        public int MaLoai { get; set; }

        public bool TrangThai { get; set; } = true;

        // Liên kết khóa ngoại đến LOAI_SAN_PHAM
        public LOAI_SAN_PHAM? LOAI_SAN_PHAM { get; set; }
    }
}
