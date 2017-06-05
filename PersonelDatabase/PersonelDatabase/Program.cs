using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            UserStorage database = new UserStorage();

            Person person = new Person(1245);
            person.SetAge(20);
            person.SetNameData("Jan", "Stary");
            person.SetGender(Gender.MALE);

            Person person1 = new Person(12456);
            person1.SetAge(20);
            person1.SetNameData("Jan", "Stary");
            person1.SetGender(Gender.MALE);

            database.AddToDatabase(person);
            database.AddToDatabase(person1);

            database.ShowPersonsList();

            Console.Read();
        }
    }
}
