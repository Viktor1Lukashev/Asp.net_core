using aspshop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspshop.Controllers
{
    public class ProductController: Controller 
    {
        private IProductRepository repository;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        [Route("Product/List")]
        public IActionResult List()
        {
            return View(repository.Products);
        }
    }
}
