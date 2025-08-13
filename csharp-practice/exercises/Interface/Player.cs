namespace csharp_practice.exercises.Interface;

public class Player : ISaveable
{
    private string _name;
    private string _weapon;
    private int _hitPoints;
    private int _strength;

    public Player(string name, int hitPoints, int strength)
    {
        _name = name;
        _weapon = "Sword";
        _hitPoints = hitPoints >= 0 ? hitPoints : 0;
        _strength = strength >= 0 ? strength : 0;
    }

    public string GetName() => _name;
    public string GetWeapon() => _weapon;
    public int GetHitPoints() => _hitPoints;
    public int GetStrength() => _strength;

    public void SetName(string name)
    {
        if (name.Length == 0) return;
        _name = name;
    }
    
    public void SetWeapon(string weapon)
    {
        if (weapon.Length == 0) return;
        _weapon = weapon;
    }
    
    public void SetHitPoints(int hitPoints)
    {
        _hitPoints = hitPoints >= 0 ? hitPoints : 0;
    }
    
    public void SetStrength(int strength)
    {
        _strength = strength >= 0 ? strength : 0;
    }
    
    public List<string> Write()
    {
        return new List<string> { _name, _hitPoints.ToString(), _strength.ToString(), _weapon };
    }

    public void Read(List<string> list)
    {
        if (list.Count == 0 || list.Count < 4) return;
        _name = list[0];
        _hitPoints = int.Parse(list[1]);
        _strength = int.Parse(list[2]);
        _weapon = list[3];
    }

    public override string ToString()
    {
        return $"Player{{name='{_name}', hitPoints={_hitPoints}, strength={_strength}, weapon='{_weapon}'}}";
    }
}