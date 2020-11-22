using System;
using System.Collections.Generic;
using System.Text;

namespace BIM313_HW1
{
    class People
    {
        public string name;
        public int age;
        public string gender;

        public People(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public virtual void Display() 
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n" +
                "(Name: {0}) - (Gender: {1}) - (Age: {2})", name, gender, age);
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetGender()
        {
            return gender;
        }
        public void SetGender(string gender)
        {
            this.gender = gender;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
    }
}
