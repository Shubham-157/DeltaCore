using DeltaCore.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DeltaCore.Controllers
{
    public class ProductController : Controller
    {
        private readonly Iproduct productRepository;

        public ProductController(Iproduct productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<IActionResult> GetProductsList()
        {
            var data = await productRepository.GetAllProducts();
            return View(data);
        }
    }
}
