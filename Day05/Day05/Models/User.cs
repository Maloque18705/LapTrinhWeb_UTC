namespace Day05.Models
{
    public class User
    {
        [Key] // Khóa chính
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
