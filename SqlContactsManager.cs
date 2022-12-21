using Npgsql;
using OnlineExercise;

namespace Contacts;

public class SqlContactsManager
{

    public void AddContact(Contact person)
    {
        var connectionString = "Host=localhost;Username=postgres;Password=postgrespw;Database=postgres;Port=55001";
        var dataSource = NpgsqlDataSource.Create(connectionString);
        
        var cmd = dataSource.CreateCommand($"INSERT INTO contacts (name,surname,phonenumber,age) VALUES('{person.Name}','{person.Surname}',{person.PhoneNumber},{person.Age})");
        cmd.ExecuteNonQuery();
    }

    public List<Contact> GetAll()
    {
        var connectionString = "Host=localhost;Username=postgres;Password=postgrespw;Database=postgres;Port=55001";
        var dataSource = NpgsqlDataSource.Create(connectionString);
        
        var cmd = dataSource.CreateCommand($"select * from contacts");
        var reader = cmd.ExecuteReader();
        List<Contact> contacts = new List<Contact>();
        while (reader.Read())
        {
            Contact contact = new Contact()
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Surname = reader.GetString(2),
                PhoneNumber = reader.GetInt32(3),
                Age = reader.GetInt32(4),
            };
            contacts.Add(contact);
        }

        return contacts;
    }

    public Contact GetByID(int id)
    {
        return null;
    }

    public void RemoveByID(int id)
    {
    }

    public void UpdateByID(int id, Contact updateContact)
    {
    }
}