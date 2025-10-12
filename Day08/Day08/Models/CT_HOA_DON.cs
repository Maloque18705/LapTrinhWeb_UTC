using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day08.Models
{
    [Table("CT_HOA_DON")]
    public class CT_HOA_DON
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Mã hóa đơn không được để trống!")]
        [ForeignKey("HOA_DON")]
        public int HoaDonID { get; set; }

        [Required(ErrorMessage = "Mã sản phẩm không được để trống!")]
        [ForeignKey("SAN_PHAM")]
        public int SanPhamID { get; set; }

        [Required(ErrorMessage = "Số lượng mua không được để trống!")]
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng mua phải lớn hơn 0!")]
        public int SoLuongMua { get; set; }

        [Required(ErrorMessage = "Đơn giá mua không được để trống!")]
        [Range(0, double.MaxValue, ErrorMessage = "Đơn giá mua phải lớn hơn hoặc bằng 0!")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal DonGiaMua { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Thành tiền phải lớn hơn hoặc bằng 0!")]
        [NotMapped] // Vì cột này được tính toán trong SQL (cột computed: SoLuongMua * DonGiaMua)
        public decimal ThanhTien => SoLuongMua * DonGiaMua;

        public bool TrangThai { get; set; } = true;

        // Khóa ngoại ánh xạ đến các bảng liên quan
        public HOA_DON? HOA_DON { get; set; }
        public SAN_PHAM? SAN_PHAM { get; set; }
    }
}
