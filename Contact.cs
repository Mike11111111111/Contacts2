using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExercise;

public class Contact
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int PhoneNumber { get; set; }
    public int Age { get; set; }

    public Contact()
    {
    }

    public override string ToString()
    {
        return $"Id:{Id}\t" +
               $"Name:{Name}\t" +
               $"Surname: {Surname}\t" +
               $"Age: {Age}\t" +
               $"Phone Number: {PhoneNumber}\t";
    }
    //dsadsadas
}