using Microsoft.AspNetCore.Mvc;

namespace Day03.Models
{
    public class StudentModel
    {
        public StudentModel() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
        
    }
}
