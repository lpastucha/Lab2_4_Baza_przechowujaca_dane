using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelDatabase
{
    class UserStorage
    {
        private List<Person> personStorage = new List<Person>();

        public void AddToDatabase(Person person)
        {
            if(person == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                personStorage.Add(person);
            }
        }
        
        public void RemoveFromDatabase(Person person) 
        {
            personStorage.Remove(person);
        }

        public void updatePerson(int personalID, Person person)
        {
               
        }

        public void ShowPersonsList()
        {
            foreach(Person person in personStorage)
            {
                Console.Out.WriteLine("Person ->" + person);
            }
        }

    

    }
}
