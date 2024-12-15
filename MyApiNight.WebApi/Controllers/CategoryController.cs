using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApiNight.Business.Abstract;
using MyApiNight.Entity.Concrete;

namespace MyApiNight.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController(ICategoryService _categoryService) : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            var value = _categoryService.TGetAll(); return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _categoryService.TInsert(category); return Ok("Ekleme başarılı");
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            _categoryService.TDelete(id);
            return Ok("Silme başarılı");
        }
        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.TUpdate(category); return Ok("Güncellendi");
        }
        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            return Ok(_categoryService.TGetById(id));
        }
    }
}