using Day04.Models;


namespace Day04.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details(int id)
        {
            var product = new ProductViewModel
            {
                Id = id,
                Name = "ArchitectUI Dashboard HTML PRO",
                Description = "When looking for a simple (in coding) yet highly practical (in use) admin dashboard, look no further than ArchitectUI.",
                Price = 69.00m,
                ImageUrl = "https://i.imgur.com/kY3S1fU.png" // Using the same image as before
            };

            return View(product);
        }

        [HttpPost]
        public IActionResult AddToCart(int productId)
        {
            // Here you would add the logic to add the product to a shopping cart.
            // For example: _shoppingCartService.AddItem(productId);

            // For now, we'll just redirect back to the product page.
            return RedirectToAction("Details", new { id = productId });
        }
    }
}
