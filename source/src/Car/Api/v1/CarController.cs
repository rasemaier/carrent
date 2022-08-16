using CarRent.Car.Api.v1;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.Car.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        // GET: api/<CarController>
        [HttpGet]
        public IEnumerable<CarResponseDto> Get()
        {
            return new CarResponseDto[]
                {
                    new CarResponseDto
                    {
                        Id = Guid.NewGuid(),
                        CarNumber = "XW82",
                        Brand ="",
                        Type ="",
                        CarClass ="Luxury"
                    }
            };
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CarController>
        [HttpPost]
        public CarResponseDto Post([FromBody] CarResponseDto value)
        {
            return value;
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
