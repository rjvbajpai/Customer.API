using Customer.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Customer.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public  List<Models.Customer> GetAll()   
        {
            var customers =  _customerService.GetCustomers().ToList();
            return customers;

        }
    }
}
