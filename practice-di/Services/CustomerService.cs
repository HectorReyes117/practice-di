using practice_di.Entities;
using practice_di.Repositories;

namespace practice_di.Services;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    
    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
    
    public async Task<List<Customer>> GetAllCustomers()
    {
        return await _customerRepository.GetCustomers();
    }
}