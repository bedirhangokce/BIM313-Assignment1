using System;
using System.Collections.Generic;
using System.Text;

namespace BIM313_HW1
{
    class LowRiskCovidPatient : People
    {
        public LowRiskCovidPatient(string name, int age, string gender) : base(name, age, gender) { }
        
        public override void Display()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n" +
                "Low risk COVID-19 patient:\n"+
                "(Name: {0}) - (Gender: {1}) - (Age: {2})", base.GetName(), base.GetGender(), base.GetAge());
        }
    }
}
