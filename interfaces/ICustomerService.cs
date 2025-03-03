using Services;

namespace Interfaces;

interface ICustomerService
{
    List<Customer> AddNewCustomer(string name, float amountOfMoney);
    List<Customer> GetAllCustomers();
    
}

