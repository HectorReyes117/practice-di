using practice_di.Entities;

namespace practice_di.Services;

public interface ICustomerService
{
    Task<List<Customer>> GetAllCustomers();
}