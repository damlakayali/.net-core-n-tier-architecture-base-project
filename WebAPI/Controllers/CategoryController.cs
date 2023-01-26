using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService; 
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var data= _categoryService.GetAll();
            if (data.Success)
            {
                return Ok(data);
            }
            else
            {
                return BadRequest(data);
            }
        }

      

        [HttpPost("add")]
        public IActionResult Post(Category category)
        {
            category.createdTime = DateTime.Now;    
            category.lastUpdatedTime= DateTime.Now; 

            var result = _categoryService.Add(category);

            if(result.Success)  return Ok(result);
            else return BadRequest(result);
        }
    }
}
