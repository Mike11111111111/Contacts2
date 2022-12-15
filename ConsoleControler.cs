namespace OnlineExercise;

public class ConsoleControler
{
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
        Console.WriteLine("Enter name");
        return Console.ReadLine();
    }

    public string GetSurname()
    {
        Console.WriteLine("Enter surname");
        return Console.ReadLine();
    }

    public int GetPhoneNumber()
    {
        Console.WriteLine("Enter phone number");
        return int.Parse(Console.ReadLine());
    }
    public int GetAge()
    {
        Console.WriteLine("Enter age");
        return int.Parse(Console.ReadLine());
    }
    public int GetId()
    {
        Console.WriteLine("Enter id");
        return int.Parse(Console.ReadLine());
    }
}
