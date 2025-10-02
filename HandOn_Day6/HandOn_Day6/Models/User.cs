using System.ComponentModel.DataAnnotations;

namespace HandOn_Day6.Models
{
    public class User
    {
        public long ID { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập tài khoản")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập mật khẩu")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Bạn chưa xác nhận mật khẩu")]
        public string ConfirmPassword {get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập tuổi")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập email")]
        public string Email { get; set; }
    }
}
