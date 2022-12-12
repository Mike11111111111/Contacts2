// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using OnlineExercise;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;



ContactsManager contactManager = new ContactsManager();
ConsoleControler consoleControler = new ConsoleControler();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Please chose an operation with contact list");
    Console.WriteLine("1.Add contact");
    Console.WriteLine("2.Show contact");
    Console.WriteLine("3.Find contact by id");
    Console.WriteLine("4.Remove contact by id");
    Console.WriteLine("5.Update contact by id");
    Console.WriteLine();

    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            Contact person = consoleControler.GetContactInfo();
            contactManager.AddContact(person);
            break;

        case 2:
            contactManager.ShowAllContacts();
            break;

        case 3:
            int id = consoleControler.GetId();
            contactManager.GetContactByID(id);
            break;

        case 4:
            id = consoleControler.GetId();
            contactManager.RemoveContactByID(id);
            break;

        case 5:
            Console.WriteLine("1.Update all");
            Console.WriteLine("2.Update name");
            Console.WriteLine("3.Update surname");
            Console.WriteLine("4.Update phone number");
            Console.WriteLine("5.Update age");
            
            int nr = int.Parse(Console.ReadLine());

            if (nr == 1)
            {
                id = consoleControler.GetId();
                person = consoleControler.GetContactInfo();
                contactManager.UpdateALLContactByID(id, person);
            }

            else if (nr == 2)
            {

                id = consoleControler.GetId();
                string name = consoleControler.GetName();
                contactManager.UpdateNameByID(id,name);
            }
            else if (nr == 3)
            {

                id = consoleControler.GetId();
                string surname = consoleControler.GetSurname();
                contactManager.UpdateSurnameByID(id, surname);
            }
            else if (nr == 4)
            {

                id = consoleControler.GetId();
                int phoneNumber = consoleControler.GetPhoneNumber();
                contactManager.UpdatePhoneNumberByID(id, phoneNumber);
            }
            else if (nr == 5)
            {

                id = consoleControler.GetId();
                int age = consoleControler.GetAge();
                contactManager.UpdateAgeByID(id, age);
            }
            break;





    }
}







