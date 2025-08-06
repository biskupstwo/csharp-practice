using System.Collections.Generic;

namespace csharp_practice.exercises.Mobile_Phone;

public class MobilePhone
{
    string myNumber;
    List<Contact> contacts;

    public MobilePhone(string myNumber)
    {
        this.myNumber = myNumber;
        this.contacts = new List<Contact>();
    }
    
    public bool AddNewContact(Contact contact)
    {
        bool doesNotExist = !contacts.Contains(contact);
        if (doesNotExist)
        {
            contacts.Add(contact);
        }

        return doesNotExist;
    }

    public bool UpdateContact(Contact oldContact, Contact newContact)
    {
        if (!contacts.Contains(oldContact)) return false;
        contacts[contacts.IndexOf(oldContact)] = newContact;
        return !contacts.Contains(oldContact) && contacts.Contains(newContact);
    }

    public bool RemoveContact(Contact contact)
    {
        if (!contacts.Contains(contact)) return false;
        return contacts.Remove(contact);
    }

    public int FindContact(Contact contact) => contacts.Contains(contact) ? contacts.IndexOf(contact) : -1;

    public int FindContact(string phoneNumber)
    {
        int index = -1;

        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].GetPhoneNumber().Equals(phoneNumber))
            {
                index = i;
                break;
            }
        }

        return index;
    }

    public Contact? QueryContact(string name)
    {
        Contact? contact = null;
        
        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].GetName().Equals(name))
            {
                contact = contacts[i];
                break;
            }
        }

        return contact;
    }
    
    public void PrintContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("Contact List is empty.");
            return;
        }
        Console.WriteLine("Contact List:");
        for (int i = 0; i < contacts.Count; i++)
        {
            Console.WriteLine($"{i+1}. {contacts[i].GetName()} -> {contacts[i].GetPhoneNumber()}");
        }
    }
}