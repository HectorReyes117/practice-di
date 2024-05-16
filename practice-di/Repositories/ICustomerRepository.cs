using practice_di.Entities;

namespace practice_di.Repositories;

public interface ICustomerRepository
{
    Task<List<Customer>> GetCustomers();
}