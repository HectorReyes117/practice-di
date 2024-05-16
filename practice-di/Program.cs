// See https://aka.ms/new-console-template for more information

using practice_di.Entities;
using practice_di.Repositories;
using practice_di.Services;

ICustomerRepository customerRepository = new CustomerRepository();
ICustomerService customerService = new CustomerService(customerRepository);

List<Customer> customers = await customerService.GetAllCustomers();

foreach (var customer in customers)
{
    Console.WriteLine($"Nombre: {customer.Name}, Edad: {customer.Age}");
}