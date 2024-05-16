using practice_di.Entities;

namespace practice_di.Repositories;

public class CustomerRepository : ICustomerRepository
{
    public Task<List<Customer>> GetCustomers()
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer()
            {
                Name = "Hector",
                Age = 20
            },
            new Customer()
            {
                Name = "Isaac",
                Age = 23
            }
        };
        return Task.FromResult(customers);
    }
}