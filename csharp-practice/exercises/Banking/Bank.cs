namespace csharp_practice.exercises.Banking;

public class Bank
{
    private string _name;
    private List<Branch> _branches;

    public Bank(string name)
    {
        _name = name;
        _branches = new List<Branch>();
    }

    public bool AddBranch(string name)
    {
        if (FindBranch(name) != null) return false;
        Branch branch = new Branch(name);
        _branches.Add(branch);
        return _branches.Contains(branch);
    }

    public bool AddCustomer(string branchName, string customerName, double initialTransaction)
    {
        Branch? branch = FindBranch(branchName);
        if (branch == null) return false;
        return branch.NewCustomer(customerName, initialTransaction);
    }

    public bool AddCustomerTransaction(string branchName, string customerName, double transaction)
    {
        Branch? branch = FindBranch(branchName);
        if (branch == null) return false;
        return branch.AddCustomerTransaction(customerName, transaction);
    }
    
    public Branch? FindBranch(string name)
    {
        Branch? branchFound = null;
        
        foreach (var branch in _branches)
        {
            if (branch.GetName() == name)
            {
                branchFound = branch;
                break;
            }
        }

        return branchFound;
    }

    public void ListCustomers(string branchName, bool printTransactions)
    {
        Branch? branch = FindBranch(branchName);
        if (branch == null)
        {
            Console.WriteLine($"{branchName} does not exist.");
            return;
        }

        Console.WriteLine($"Customer details for branch {branch.GetName()}");

        for (int i = 0; i < branch.GetCustomers().Count; i++)
        {
            Customer customer = branch.GetCustomers()[i];
            Console.WriteLine($"Customer: {customer.GetName()}[{i+1}]");
            if (printTransactions)
            {
                Console.WriteLine("Transactions");
                for (int j = 0; j < customer.GetTransactions().Count(); j++)
                {
                    double transaction = customer.GetTransactions()[j];
                    Console.WriteLine($"[{j+1}] Amount {transaction}");
                }
            }
        }
    }
}