using System.Collections.Generic;
using GestionProduit.Repositories;
using Microsoft.AspNetCore.Mvc;
using GestionProduit.Models;
using System.Linq;

namespace GestionProduit.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _productRepo;
        public ProductController(IProductRepo _productRepo)
        {
            this._productRepo = _productRepo;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            return Ok(_productRepo.GetAll());
        }



        [HttpGet]
        [Route("category/{id}")]
        public ActionResult<Product> GetProductsByCategoryId(int id)
        {
            var products = _productRepo.getByCategoryId(id);
            if (products.Count() > 0)
            {
                return Ok(products);
            }
            return NotFound(new { message = "Products not found" });
        }


        [HttpPost]
        public ActionResult CreateNewProduct([FromBody] Product product)
        {
            _productRepo.Add(product);
            return Ok(_productRepo.GetAll());
        }
        [HttpPost]
        [Route("create")]
        public ActionResult CreateDbProduct([FromBody] Product product)
        {
            _productRepo.Add(product);
            return Ok(_productRepo.GetAll());
        }


        [HttpGet]
        [Route("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = _productRepo.GetById(id);
            if (product != null)
            {
                return Ok(product);
            }
            return NotFound(new { message = "Product not found" });
        }


    }
}