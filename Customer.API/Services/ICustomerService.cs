namespace Customer.API.Services
{
    public interface ICustomerService
    {
        public List<Customer.API.Models.Customer> GetCustomers();
    }
}
