using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day06_LamThem.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [
            Display(Name = "Tên Sản Phẩm"),
            Required(ErrorMessage = "Tên Sản Phẩm Không Được Để Trống"),
            MinLength(6, ErrorMessage = "Tên Sản Phẩm Phải Có Ít Nhất 6 Ký Tự"),
            MaxLength(150, ErrorMessage = "Tên Sản Phẩm Không Được Quá 150 Ký Tự"),
            Column(TypeName ="nvarchar(150)")
        ]
        public string Name { get; set; }
        [Display(Name = "Hình ảnh")]
        [Required(ErrorMessage = "Hình ảnh không được để trống")]
        [DataType(DataType.Upload)]
        [Remote(action: "ImageValidate", controller:"Product", ErrorMessage = "Hình ảnh không hợp lệ")]
        public string Image { get; set; }
        [Display(Name = "Giá chuẩn")]
        [Required(ErrorMessage = "Giá chuẩn không được để trống")]
        [Range(100000, double.MaxValue, ErrorMessage = "Giá chuẩn phải từ 100000 trở lên")]
        [DataType(DataType.Text)]
        [Column(TypeName = "int")]
        public float Price { get; set; }
        [Display(Name = "Giá bán")]
        [Required(ErrorMessage = "Giá bán không được để trống")]
        [Range(0, double.MaxValue, ErrorMessage = "Giá bán phải từ 0 trở lên")]
        [Remote(action:"PriceValidate", controller:"Product", ErrorMessage = "Giá bán phải nhỏ hơn giá chuẩn 10%")]
        [Column(TypeName ="int")]
        public float SalePrice { get; set; }
        [Display(Name = "Mô tả sản phẩm")]
        [Required(ErrorMessage = "Mô tả sản phẩm không được để trống")]
        [MaxLength(1500, ErrorMessage = "Mô tả sản phẩm không được quá 1500 ký tự")]
        [Remote(action:"WordFilter", controller:"Product", ErrorMessage = "Mô tả có chứa từ ngữ không phù hợp")]
        [Column(TypeName ="nvarchar(1500)")]
        public string Description { get; set; }
    }
}
