using Contacts;

namespace OnlineExercise;

public class Menu
{
    private SqlContactsManager _sqlContactManager;
    private ConsoleControler _consoleControler;

    public Menu(SqlContactsManager sqlContactManager, ConsoleControler consoleControler)
    {
        _sqlContactManager = sqlContactManager;
        _consoleControler = consoleControler;
    }
    
    public void ShowMainMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Please chose an operation with contact list");
        Console.WriteLine("1.Add contact");
        Console.WriteLine("2.Show all contacts");
        Console.WriteLine("3.Show contact by id");
        Console.WriteLine("4.Remove contact by id");
        Console.WriteLine("5.Update contact by id");
        Console.WriteLine();

        int menuOption = int.Parse(Console.ReadLine());
        
        switch (menuOption)
        {
            case 1:
                AddContact();
                break;

            case 2:
                ShowAllContacts();
                break;

            case 3:
                ShowContact();
                break;

            case 4:
                RemoveContact();
                break;
            
            case 5:
                UpdateContact();
                break;
        }
    }

    public void AddContact()
    {
        Contact person = _consoleControler.GetContactInfo();
        _sqlContactManager.AddContact(person);
    }

    public void ShowAllContacts()
    {
        List<Contact> contacts = _sqlContactManager.GetAll();
        foreach (Contact contact in contacts)
        {
            Console.WriteLine(contact);
        }
    }
    public void ShowContact()
    {
        int id = _consoleControler.GetId();
        Contact foundContact = _sqlContactManager.GetByID(id);
        Console.WriteLine(foundContact);
    }

    public void RemoveContact()
    {
        int id = _consoleControler.GetId();
        _sqlContactManager.RemoveByID(id);
    }
    
    public void UpdateContact()
    {
        int id = _consoleControler.GetId();
        Contact updateContact = _consoleControler.GetContactInfo();
        _sqlContactManager.UpdateByID(id, updateContact);
    }
}