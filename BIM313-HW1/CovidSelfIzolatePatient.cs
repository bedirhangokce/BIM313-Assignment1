using System;
using System.Collections.Generic;
using System.Text;

namespace BIM313_HW1
{
    class CovidSelfIzolatePatient : People
    {
        public CovidSelfIzolatePatient(string name, int age, string gender) : base(name, age, gender) { }
        
        public override void Display()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n" +
                "COVID-19 self-isolating patient:\n" +
                "(Name: {0}) - (Gender: {1}) - (Age: {2})", base.GetName(), base.GetGender(), base.GetAge());
        }
    }
}
