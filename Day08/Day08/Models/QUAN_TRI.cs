using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day08.Models
{
    [Table("QUAN_TRI")]
    public class QUAN_TRI
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Tên tài khoản không được để trống!")]
        [StringLength(50)]
        public string TaiKhoan { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống!")]
        [StringLength(100)]
        public string MatKhau { get; set; }

        public bool TrangThai { get; set; } = true;        
    }
}
