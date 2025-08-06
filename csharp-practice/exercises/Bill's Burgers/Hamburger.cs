namespace csharp_practice.exercises.Bill_s_Burgers;

public class Hamburger
{
    protected string Name;
    protected string Meat;
    protected double Price;
    protected string BreadRollType;
    protected string Addition1Name = string.Empty;
    protected double Addition1Price;
    protected string Addition2Name = string.Empty;
    protected double Addition2Price;
    protected string Addition3Name = string.Empty;
    protected double Addition3Price;
    protected string Addition4Name = string.Empty;
    protected double Addition4Price;
    
    public Hamburger(string name, string meat, double price, string breadRollType)
    {
        Name = name;
        Meat = meat;
        Price = price;
        BreadRollType = breadRollType;
        HamburgerDescription();
    }

    private void HamburgerDescription()
    {
        Console.WriteLine($"{Name} hamburger on a {BreadRollType} with {Meat}, price is {Price}");
    }

    protected void AdditionDescription(string name, double price)
    {
        Console.WriteLine($"Added {name} for an extra {price}");
    }
    
    public virtual void AddHamburgerAddition1(string name, double price)
    {
        Addition1Price = price >= 0 ? price : 0;
        Addition1Name = name;
        AdditionDescription(Addition1Name, Addition1Price);
    }
    
    public virtual void AddHamburgerAddition2(string name, double price)
    {
        Addition2Price = price >= 0 ? price : 0;
        Addition2Name = name;
        AdditionDescription(Addition2Name, Addition2Price);
    }
    
    public virtual void AddHamburgerAddition3(string name, double price)
    {
        Addition3Price = price >= 0 ? price : 0;
        Addition3Name = name;
        AdditionDescription(Addition3Name, Addition3Price);
    }
    
    public virtual void AddHamburgerAddition4(string name, double price)
    {
        Addition4Price = price >= 0 ? price : 0;
        Addition4Name = name;
        AdditionDescription(Addition4Name, Addition4Price);
    }

    public virtual double ItemizeHamburger()
    {
        return Price + Addition1Price + Addition2Price + Addition3Price + Addition4Price;
    }
}