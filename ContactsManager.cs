namespace OnlineExercise;

public class ContactsManager
{
    private List<Contact> contactList = new List<Contact>();

  public void AddContact(Contact person)
    {
        contactList.Add(person);       
    }

    public void ShowAllContacts()
    {
       foreach(Contact contact in contactList)
        {
            Console.WriteLine(contact);
        }
    }

    public void GetContactByID(int id)
    {
        Contact found =contactList.Find(x => x.Id == id);
        Console.WriteLine(found);
    }

    public void RemoveContactByID(int id)
    {
        Contact found = contactList.Find(x => x.Id == id);
        contactList.Remove(found);
    }

    public void UpdateALLContactByID(int id,Contact person)
    {
        int index = contactList.FindIndex(x => x.Id == id);
        person.Id = id;
        contactList[index] = person;
        Console.WriteLine(person);      
    }

    public void UpdateNameByID(int id, string name)
    {
        int index = contactList.FindIndex(x => x.Id == id);
        Contact found = contactList.Find(x => x.Id == id);        
        found.Id = id;
        found.Name = name;
        contactList[index] = found;
        Console.WriteLine(found);
    }


    public void UpdateSurnameByID(int id, string surname)
    {
        int index = contactList.FindIndex(x => x.Id == id);
        Contact found = contactList.Find(x => x.Id == id);
        found.Id = id;
        found.Surname = surname;
        contactList[index] = found;
        Console.WriteLine(found);
    }

    public void UpdatePhoneNumberByID(int id, int phone)
    {
        int index = contactList.FindIndex(x => x.Id == id);
        Contact found = contactList.Find(x => x.Id == id);
        found.Id = id;
        found.PhoneNumber = phone;
        contactList[index] = found;
        Console.WriteLine(found);
    }
    public void UpdateAgeByID(int id, int age)
    {
        int index = contactList.FindIndex(x => x.Id == id);
        Contact found = contactList.Find(x => x.Id == id);
        found.Id = id;
        found.Age = age;
        contactList[index] = found;
        Console.WriteLine(found);
    }
}



