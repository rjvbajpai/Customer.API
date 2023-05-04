

namespace Customer.API.Services
{
    public class CustomerService: ICustomerService
    {   

        public  List<Customer.API.Models.Customer> GetCustomers()
        {
            var customers =  new List<Customer.API.Models.Customer>()
            {
                new Models.Customer(){Id = 1, Name = "Rajiv",Address ="Park View"},
                new Models.Customer(){ Id = 2,Name = "Prasoon",Address = "Park View"},
                new Models.Customer(){ Id = 3,Name = "Amrita",Address = "Park View"},
                new Models.Customer(){ Id = 4,Name = "Akash",Address = "Park View"},
                new Models.Customer(){ Id = 5,Name = "Rajesh",Address = "Park View"},
                new Models.Customer(){ Id = 6,Name = "Munna",Address = "Park View"},
            };
            return customers;
        }

        
    }
}
