namespace csharp_practice.exercises.Interface;

public class Monster : ISaveable
{
    private string _name;
    private int _hitPoints;
    private int _strength;

    public Monster(string name, int hitPoints, int strength)
    {
        _name = name;
        _hitPoints = hitPoints >= 0 ? hitPoints : 0;
        _strength = strength >= 0 ? strength : 0;
    }

    public string GetName() => _name;
    public int GetHitPoints() => _hitPoints;
    public int GetStrength() => _strength;
    
    public List<string> Write()
    {
        return new List<string> { _name, _hitPoints.ToString(), _strength.ToString()};
    }

    public void Read(List<string> list)
    {
        if (list.Count == 0 || list.Count < 3) return;
        _name = list[0];
        _hitPoints = int.Parse(list[1]);
        _strength = int.Parse(list[2]);
    }

    public override string ToString()
    {
        return $"Monster{{name='{_name}', hitPoints={_hitPoints}, strength={_strength}}}";
    }
}