namespace csharp_practice.exercises.Bill_s_Burgers;

public class HealthyBurger : Hamburger
{
    protected string HealthyExtra1Name  = string.Empty;
    protected double HealthyExtra1Price;
    protected string HealthyExtra2Name  = string.Empty;
    protected double HealthyExtra2Price;

    public HealthyBurger(string meat, double price) : base("Healthy", meat, price,"Brown rye")
    {
        
    }

    public void AddHealthyAddition1(string healthyExtra1Name, double healthyExtra1Price)
    {
        HealthyExtra1Name = healthyExtra1Name;
        HealthyExtra1Price = healthyExtra1Price >= 0 ? healthyExtra1Price : 0;
        AdditionDescription(HealthyExtra1Name, HealthyExtra1Price);
    }
    
    public void AddHealthyAddition2(string healthyExtra2Name, double healthyExtra2Price)
    {
        HealthyExtra2Name = healthyExtra2Name;
        HealthyExtra2Price = healthyExtra2Price >= 0 ? healthyExtra2Price : 0;
        AdditionDescription(HealthyExtra2Name, HealthyExtra2Price);
    }

    public override double ItemizeHamburger()
    {
        return base.ItemizeHamburger() + HealthyExtra1Price + HealthyExtra2Price;
    }
}