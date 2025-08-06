namespace csharp_practice.exercises;

public class Person
{
    private string _firstName = "";
    private string _lastName = "";
    private int _age;

    public string GetFirstName()
    {
        return _firstName;
    }

    public string GetLastName()
    {
        return _lastName;
    }

    public int GetAge()
    {
        return _age;
    }

    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }

    public void SetLastName(string lastName)
    {
        _lastName = lastName;
    }

    public void SetAge(int age)
    {
        _age = age >= 0 && age <= 100 ? age : 0;
    }

    public bool IsTeen() => _age >= 12 && _age < 20;

    public string GetFullName()
    {
        if (string.IsNullOrEmpty(_firstName) && string.IsNullOrEmpty(_lastName)) return "";
        if (string.IsNullOrEmpty(_firstName)) return _lastName;
        if (string.IsNullOrEmpty(_lastName)) return _firstName;
        return $"{_firstName} {_lastName}";
    }
}