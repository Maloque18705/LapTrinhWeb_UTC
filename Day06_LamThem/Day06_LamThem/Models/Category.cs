using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day06_LamThem.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [
            Display(Name = "Tên danh mục"),
            Required(ErrorMessage = "Tên danh mục Không Được Để Trống"),
            MinLength(6, ErrorMessage = "Tên danh mục Phải Có Ít Nhất 6 Ký Tự"),
            MaxLength(150, ErrorMessage = "Tên danh mục không được quá 150 Ký Tự"),
            Column(TypeName = "nvarchar(150)")
        ]
        public string Name { get; set; }
        
    }
}
