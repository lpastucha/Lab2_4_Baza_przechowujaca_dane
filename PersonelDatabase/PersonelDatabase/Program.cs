using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelDatabase
{
    class Program
    {
        private UserStorage database = new UserStorage();

        public Program()
        {
            Run();
        }

        private void Run()
        {
            Console.WriteLine("Welcom to SimpleDatabase program!");
            ShowProgramModule();
        }

        private void ShowProgramModule()
        {
            ShowMenu();
            RunModule(GetChoice());
        }

        private void ShowMenu()
        {
            Console.WriteLine("What would you want to do?");
            Console.WriteLine("\t 1 -> \tAdd user");
            Console.WriteLine("\t 2 -> \tRemove user");
            Console.WriteLine("\t 3 -> \tShow available users");
            Console.WriteLine("\t 4 -> \tExit");
        }

        private int GetChoice()
        {
            return (int) Console.Read();
        } 

        private void RunModule(int choice)
        {
            switch (choice)
            {
                case 1: ModuleAdd(); break;
                case 2: ModuleRemove(); break;
                case 3: ModuleShow(); break;
                case 4: return;
                default: Console.Clear(); ShowChoiceError();  ShowMenu(); break;
            }

            ShowProgramModule();
        }

        private void ModuleAdd()
        {
            Console.Clear();
            Console.WriteLine("ID : ");
            try
            {
                int ID = Console.Read();
                Person person = new Person(ID);
                Console.WriteLine("Name: ");
                String name = Console.ReadLine();
                Console.WriteLine("Lastname: ");
                String lastname = Console.ReadLine();
                person.SetNameData(name, lastname);
                Console.WriteLine("Age : ");
                int age = Console.Read();
                person.SetAge(age);
                Console.WriteLine("Choose GENGER: 1 - MALE ; 2 - FEMALE");
                int gender = Console.Read();
                switch (gender)
                {
                    case 1: person.SetGender(Gender.MALE);break ;
                    case 2: person.SetGender(Gender.FEMALE); break;
                    default: break;
                }
                database.AddToDatabase(person);
                Console.WriteLine("Person added: " + person);

            }
            catch(Exception e)
            {
                Console.WriteLine("Wrong data format. Press Enter and try again...");
                Console.Read();
                ModuleAdd();
            }

            
        }

        private void ModuleRemove()
        {
            Console.Clear();
        }

        private void ModuleShow()
        {
            Console.Clear();
            database.ShowPersonsList();
        }

        private void ShowChoiceError()
        {
            Console.WriteLine("Wrong Choice try again!");
        }

        public static void Main(string[] args)
        {
            new Program();
        }
    }
}
