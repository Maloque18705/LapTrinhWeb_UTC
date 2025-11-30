using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace QLBanSach.Models
{
    public class TSachPartial : Controller
    {
        [ModelMetadataType(typeof(TSachMetadata))]
        public partial class TSach
        {

        }
        public class TSachMetadata
        {
            [Range(10000, 1000000, ErrorMessage = "Giá phải từ 10,000 đến 1,000,000")]
            public double? GiaBan { get; set; }
            [RegularExpression(@".*\.(jpg|png|tiff|gif)$", ErrorMessage = "Ảnh phải có đuôi jpg, png, tiff hoặc gif")]
            public string? Anh { get; set; }
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
