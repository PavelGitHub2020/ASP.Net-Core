using FeedbackApp.BLL.Interfaces;
using FeedbackApp.BLL.VMs.Product;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
       
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public Guid CreateProductAsync([FromForm] CreateProduct product)
        {
            return (_productService.CreateProductAsync(product)).Result;
        }

        [HttpGet]
        [Route("getall")]
        public List<CreateProduct> GetAllProducts(Func<ProductController, bool> func)
        {
            return _productService.FindProductsByFunc(null);
        }
    }
}
