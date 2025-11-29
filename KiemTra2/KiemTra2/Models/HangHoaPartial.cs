using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace KiemTra2.Models

{
    [ModelMetadataType(typeof(HangHoaMetadata))]
    public partial class HangHoa
    {
    }
     public class HangHoaMetadata
    {
        [Range(100, 5000, ErrorMessage = "Giá phải nằm trong khoảng từ 100 đến 5000.")]
        public double? Gia { get; set; }

        [RegularExpression(@".*\.(jpg|png|gif|tiff)$", ErrorMessage = "Ảnh phải có đuôi .jpg, .png, .gif, hoặc .tiff")]
        public string? Anh { get; set; }
    }
}

