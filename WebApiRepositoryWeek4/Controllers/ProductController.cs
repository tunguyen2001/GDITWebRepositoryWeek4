using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiRepositoryWeek4.Services;
using WebApiRepositoryWeek4.Repositories.ProductRepository;
using WebApiRepositoryWeek4.Models;

namespace WebApiRepositoryWeek4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return new JsonResult(_productService.GetProductDetailDtos());
        }

        [HttpGet("id")]
        public JsonResult GetById(int id)
        {
            return new JsonResult(_productService.GetById(id)) ;
        }

        [HttpPost]
        public JsonResult CreateProduct(Products products)
        {
            _productService.Insert(products);
            return new JsonResult("inserted successfully!");
        }

        [HttpPut]
        public JsonResult UpdateProduct(Products products)
        {
            _productService.Update(products);
            return new JsonResult("updated successfully!!");
        }

        [HttpDelete]
        public JsonResult DeleteProduct(int id)
        {
            _productService.Delete(id);
            return new JsonResult("Deleted successfully!");
        }

    }
}
