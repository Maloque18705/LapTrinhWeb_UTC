using Microsoft.AspNetCore.Mvc;
using Day06_LamThem.Models;
namespace Day06_LamThem.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [AcceptVerbs("GET","POST")]
        public IActionResult PriceValidate(float SalePrice, float Price)
        {
            if(SalePrice > Price * 0.9)
            {
                return Json($"Giá bán phải nhỏ hơn giá chuẩn 10%");
            }
            return Json(true);
        }
        [AcceptVerbs("GET","POST")]
        public IActionResult WordFilter(string Description)
        {
            string[] badWords = new string[] { "fuck", "admin", "đĩ", "đụ" };
            foreach(var item in badWords)
            {
                if(Description.Contains(item))
                {
                    return Json($"Mô tả có chứa từ ngữ không phù hợp");
                }
            }
            return Json(true);
        }
    }
}
