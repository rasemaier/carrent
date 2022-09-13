using CarRent.Rent.Api.v1;
using CarRent.Rent.Domain;
using Microsoft.AspNetCore.Mvc;

namespace RentRent.Rent.Api.v1
{
    [Route("api/v1/rent")]
    [ApiController]
    public class RentController : Controller
    {
        private readonly IRentRepository _repository;

        public RentController(IRentRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<RentController>
        [HttpGet]
        public IActionResult Get()
        {
            var Rents = _repository.GetAll();
            var RentDtos = Rents.Select(c => new RentResponseDto
            {
                RentId = c.Id,
                RentNumber = c.RentNumber
               
            });
            return Ok(RentDtos);

        }

        // GET api/<RentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
