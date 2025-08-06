namespace csharp_practice.exercises.Mobile_Phone;

public class Contact
{
    private string _name;
    private string _phoneNumber;

    private Contact (string name, string phoneNumber)
    {
        _name = name;
        _phoneNumber = phoneNumber;
    }

    public string GetName() => _name;
    public string GetPhoneNumber() => _phoneNumber;

    public static Contact CreateContact(string name, string phoneNumber)
    {
        return new Contact(name, phoneNumber);
    }
}