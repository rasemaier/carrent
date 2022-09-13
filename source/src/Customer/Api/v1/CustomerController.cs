using CarRent.Customer.Api.v1;
using CarRent.Customer.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CustomerCustomer.Customer.Api.v1
{
    [Route("api/v1/customer")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _repository;

        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public IActionResult Get()
        {
            var Customers = _repository.GetAll();
            var CustomerDtos = Customers.Select(c => new CustomerResponseDto
            {
                CustomerId = c.Id,
                CustomerNumber = c.CustomerNumber
            });
            return Ok(CustomerDtos);

        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
