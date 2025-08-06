namespace csharp_practice.exercises.Composition;

public class Wall
{
    private string _direction;

    public Wall(string direction) => _direction = direction;

    public string GetDirection() => _direction;
}