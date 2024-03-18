using DataBase;
using KimiWomanAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace KimiWomanAPI.Controllers
{
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProducts _products;
        public ProductsController(IProducts products)
        {
            _products = products;
        }

        [HttpGet("api/GetAllProducts")]
        public IEnumerable<Products> GetAllProducts()
        {
            return _products.GetAllProducts();
        }

        [HttpGet("api/GetProductsByCategory/{idCategory}")]
        public IEnumerable<Products> GetProductsByCategory(int idCategory)
        {
            return _products.GetProductsByCategory(idCategory);
        }

        [HttpGet("api/GetProductsBySubCategory/{idSubCategory}")]
        public IEnumerable<Products> GetProductsBySubCategory(int idSubCategory)
        {
            return _products.GetProductsBySubCategory(idSubCategory);
        }
    }
}
