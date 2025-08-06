namespace csharp_practice.exercises.Banking;

public class BankingPlayground
{
    public static void Playground()
    {
        Bank bank = new Bank("National Australia Bank");
	 
        bank.AddBranch("Adelaide");
	 
        bank.AddCustomer("Adelaide", "Tim", 50.05);
        bank.AddCustomer("Adelaide", "Mike", 175.34);
        bank.AddCustomer("Adelaide", "Percy", 220.12);
	 
        bank.AddCustomerTransaction("Adelaide", "Tim", 44.22);
        bank.AddCustomerTransaction("Adelaide", "Tim", 12.44);
        bank.AddCustomerTransaction("Adelaide", "Mike", 1.65);
	 
        bank.ListCustomers("Adelaide", true);
        Console.WriteLine("-------");
        bank.ListCustomers("Adelaide", false);
    }
}