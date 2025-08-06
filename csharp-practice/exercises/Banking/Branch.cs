namespace csharp_practice.exercises.Banking;

public class Branch
{
    private string _name;
    private List<Customer> _customers;

    public Branch(string name)
    {
        _name = name;
        _customers = new List<Customer>();
    }

    public string GetName() => _name;
    public List<Customer> GetCustomers() => _customers;

    public bool NewCustomer(string name, double initialTransaction)
    {
        if (FindCustomer(name) != null) return false;
        Customer customer = new Customer(name);
        _customers.Add(customer);
        AddCustomerTransaction(name, initialTransaction);
        return _customers.Contains(customer) && customer.GetTransactions().Contains(initialTransaction);
    }

    public bool AddCustomerTransaction(string name, double transaction)
    {
        Customer? customer = FindCustomer(name);
        if (customer == null) return false;
        customer.AddTransaction(transaction);
        return customer.GetTransactions().Contains(transaction);
    }

    public Customer? FindCustomer(string name)
    {
        Customer? customerFound = null;
        
        foreach (var customer in _customers)
        {
            if (customer.GetName() == name)
            {
                customerFound = customer;
                break;
            }
        }

        return customerFound;
    }
}