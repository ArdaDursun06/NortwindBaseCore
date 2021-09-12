using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryServices _categoryServices;

        public CategoriesController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }



        [HttpGet("getall")]
        public IActionResult GetAll()
        {
         
            var result = _categoryServices.GetAll();
            if (result.Success)
            {
                return Ok(result);
            } 
            return BadRequest(result);
        }

    }
}
