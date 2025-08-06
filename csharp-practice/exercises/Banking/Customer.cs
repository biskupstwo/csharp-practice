namespace csharp_practice.exercises.Banking;

public class Customer
{
    private string _name;
    private List<double> _transactions;

    public Customer(string name)
    {
        _name = name;
        _transactions = new List<double>();
    }
    
    public string GetName() => _name;
    public List<double> GetTransactions() => _transactions;
    public void AddTransaction(double transaction) => _transactions.Add(transaction);
}