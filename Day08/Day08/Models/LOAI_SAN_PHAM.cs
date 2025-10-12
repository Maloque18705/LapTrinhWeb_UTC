using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day08.Models
{
    [Table("LOAI_SAN_PHAM")]
    public class LOAI_SAN_PHAM
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Mã loại sản phẩm không được để trống!")]
        [StringLength(20, ErrorMessage = "Mã loại sản phẩm không được vượt quá 20 ký tự!")]
        public string MaLoai { get; set; }

        [Required(ErrorMessage = "Tên loại sản phẩm không được để trống!")]
        [StringLength(100, ErrorMessage = "Tên loại sản phẩm không được vượt quá 100 ký tự!")]
        public string TenLoai { get; set; }

        public bool TrangThai { get; set; } = true;
    }
}
