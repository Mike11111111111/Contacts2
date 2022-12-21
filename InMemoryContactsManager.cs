namespace OnlineExercise;

public class InMemoryContactsManager
{
    private List<Contact> contactList = new List<Contact>();

    public void AddContact(Contact person)
    {
        contactList.Add(person);
    }

    public List<Contact> GetAll()
    {
        return contactList;
    }

    public Contact GetByID(int id)
    {
        Contact contact = contactList.Find(x => x.Id == id);

        return contact;
    }

    public void RemoveByID(int id)
    {
        Contact found = contactList.Find(x => x.Id == id);
        contactList.Remove(found);
    }

    public void UpdateByID(int id, Contact updateContact)
    {
        Contact contact = contactList.Find(x => x.Id == id);
        contact.Name = updateContact.Name;
        contact.Surname = updateContact.Surname;
        contact.PhoneNumber = updateContact.PhoneNumber;
        contact.Age = updateContact.Age;
    }
}