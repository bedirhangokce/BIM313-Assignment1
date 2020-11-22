using System;
using System.Collections.Generic;
using System.Text;

namespace BIM313_HW1
{
    class CovidNegativePeople : People
    {
        public CovidNegativePeople(string name, int age, string gender) : base(name, age, gender) { }

        public override void Display()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n" +
                "COVID-19 negative or inconclusive people:\n" +
                "(Name: {0}) - (Gender: {1}) - (Age: {2})", base.GetName(), base.GetGender(), base.GetAge());
        }
    }
}
