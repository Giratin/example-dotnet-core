using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionProduit.Models;
using GestionProduit.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GestionProduit.Controllers
{
    // [ApiController]
    // [Route("/api/categories")]
    public class CategoryController : ControllerBase
    {
        private readonly IProductRepo _productRepo;
        public CategoryController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        // [HttpGet]
        // [Route("/")]
        // public ActionResult<IEnumerable<Product>> GetAllCategories()
        // {
        //     return Ok(_productRepo.getAll());
        // }
    }
}