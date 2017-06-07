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
            try
            {
                return Int16.Parse(Console.ReadLine());
            }catch(Exception e)
            {
               // Console.Error.Write(e);
            }
            return 1000;
        } 

        private void RunModule(int choice)
        {
            switch (choice)
            {
                case 1: ModuleAdd(); break;
                case 2: ModuleRemove(); break;
                case 3: ModuleShow(); break;
                case 4: return;
                default: Console.Clear(); ShowChoiceError(); break;
            }

            ShowProgramModule();
        }

        private void ModuleAdd()
        {
            Console.Clear();
            Console.WriteLine("ID : ");
            try
            {
                int ID = Int32.Parse(Console.ReadLine());
                Person person = new Person(ID);
                Console.WriteLine("Name: ");
                String name = Console.ReadLine();
                Console.WriteLine("Lastname: ");
                String lastname = Console.ReadLine();
                person.SetNameData(name, lastname);
                Console.WriteLine("Age : ");
                int age = Int16.Parse(Console.ReadLine());
                person.SetAge(age);
                Console.WriteLine("Choose GENGER: 1 - MALE ; 2 - FEMALE");
                int gender = Int16.Parse(Console.ReadLine());
                switch (gender)
                {
                    case 1: person.SetGender(Gender.MALE);break ;
                    case 2: person.SetGender(Gender.FEMALE); break;
                    default: break;
                }
                database.AddToDatabase(person);
                Console.Clear();
                Console.WriteLine("Person added: " + person);

            }
            catch(Exception e)
            {
                Console.Write("Wrong data format. Press Enter and try again...");
                Console.ReadKey();
                ModuleAdd();
            }
        }

        private void ModuleRemove()
        {
            try
            {
                Console.Clear();
                database.ShowPersonsList();
                Console.WriteLine("Choose person nr to remove!");
                int result = Int32.Parse(Console.ReadLine());
                database.RemoveFromDatabase(database.getPerson(result-1));
            }
            catch(Exception e)
            {
                ModuleRemove();
            }
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
