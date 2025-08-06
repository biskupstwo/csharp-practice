namespace csharp_practice.exercises.Bill_s_Burgers;

public class DeluxeBurger : Hamburger
{
    public DeluxeBurger() : base("Deluxe", "Sausage & Bacon", 14.54, "White roll")
    {
        base.AddHamburgerAddition1("Chips", 2.75);
        base.AddHamburgerAddition2("Drink", 1.81);
    }
    public override void AddHamburgerAddition1(string name, double price)
    {
        Console.WriteLine("Cannot not add additional items to a deluxe burger");
    }
    
    public override void AddHamburgerAddition2(string name, double price)
    {
        Console.WriteLine("Cannot not add additional items to a deluxe burger");
    }
    
    public override void AddHamburgerAddition3(string name, double price)
    {
        Console.WriteLine("Cannot not add additional items to a deluxe burger");
    }
    
    public override void AddHamburgerAddition4(string name, double price)
    {
        Console.WriteLine("Cannot not add additional items to a deluxe burger");
    }
}