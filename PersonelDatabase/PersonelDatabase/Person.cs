using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelDatabase
{
    enum Gender { MALE,FEMALE}
    class Person
    {
        private String name;
        private String lastname;
        private int age;
        private Gender gender;
        private int ID;

        public Person(int ID)
        {
            this.ID = ID;
        }
        public void SetNameData(String name, String lastName)
        {
            this.name = name;
            this.lastname = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SetGender(Gender gender)
        {
            this.gender = gender;
        }

        override
   public String ToString()
        {
            return "[Name: " + this.name + " Lastname: " + this.lastname + " Age: " + this.age + " Gender: " + this.gender +"]";
        }
    }
}
