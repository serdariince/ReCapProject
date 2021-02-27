using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private ICarImageServices _carImageServices;

        public CarImagesController(ICarImageServices carImageServices)
        {
            _carImageServices = carImageServices;
        }


        [HttpGet("getall")]
        public IActionResult GelAll()
        {
            var result = _carImageServices.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getid")]
        public IActionResult GetId(int id)
        {
            var result = _carImageServices.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getcarbyid")]
        public IActionResult GetcarById(int id)
        {
            var result = _carImageServices.GetCarById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult AddAsync([FromForm(Name = ("Image"))] IFormFile file, [FromForm] CarImage carImage)
        {

          var result= _carImageServices.Add(file,carImage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}
