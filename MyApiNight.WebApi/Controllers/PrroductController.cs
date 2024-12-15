using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApiNight.Business.Abstract;
using MyApiNight.Entity.Concrete;

namespace MyApiNight.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrroductController(IProductService _productService) : ControllerBase
    {
        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _productService.TGetAll(); return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _productService.TInsert(product); return Ok("Ekleme başarılı");
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            _productService.TDelete(id); return Ok("Silindi");
        }
        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.TUpdate(product); return Ok("Güncellendi");
        }
        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            return Ok(_productService.TGetById(id));
        }

        [HttpGet("GetProductCount")]
        public IActionResult GetProductCount()
        {
            return Ok(_productService.TGetProductCount());
        }
    }
}