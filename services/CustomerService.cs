using System.Runtime.CompilerServices;
using Interfaces;

namespace Services;


class CustomerService : ICustomerService
{

    public List<Customer> AddNewCustomer(string name, float amountOfMoney)
    {
        allCustomers.Add(new Customer(name, amountOfMoney));
        return allCustomers;
    }

    private List<Customer> allCustomers = new List<Customer>()
    {
        new Customer("Ramil", 140f),
        new Customer("Rajab", 1500f),
        new Customer("Kamal", 30f),
        new Customer("Ilon Mask", 2400f),
        new Customer("Ronaldo", 720.7f)
    };

    public List<Customer> GetAllCustomers()
        => allCustomers;
}

class Customer
{
    internal string Name { get; set; }
    internal float AmountOfMoney { get; set; }

    internal Customer(string name, float amountOfMoney)
    {
        Name = name;
        AmountOfMoney = amountOfMoney;
    }
}