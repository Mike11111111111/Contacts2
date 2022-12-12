using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExercise;

public class ConsoleControler
{
    // miau
    public Contact GetContactInfo()
    {
        Contact person = new Contact();

        Console.WriteLine("Enter name");
        person.Name = Console.ReadLine();

        Console.WriteLine("Enter surname");
        person.Surname = Console.ReadLine();

        Console.WriteLine("Enter phone number");
        person.PhoneNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter age");
        person.Age = int.Parse(Console.ReadLine());

        return person;
    }

    public string GetName()
    {
        Contact person = new Contact();

        Console.WriteLine("Enter name");
        person.Name = Console.ReadLine();

        return person.Name;
    }

    public string GetSurname()
    {
        Contact person = new Contact();

        Console.WriteLine("Enter surname");
        person.Surname = Console.ReadLine();

        return person.Surname;
    }

    public int GetPhoneNumber()
    {
        Contact person = new Contact();

        Console.WriteLine("Enter Phone Number");
        person.PhoneNumber = int.Parse(Console.ReadLine());

        return person.PhoneNumber;
    }
    public int GetAge()
    {
        Contact person = new Contact();

        Console.WriteLine("Enter age");
        person.Age = int.Parse(Console.ReadLine());

        return person.Age;
    }
    public int GetId()
    {
        Console.WriteLine("Enter id");
        int id = int.Parse(Console.ReadLine());
        return id;
    }
}
