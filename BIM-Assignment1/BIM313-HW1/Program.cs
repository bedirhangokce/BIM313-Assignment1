using System;
using System.Collections.Generic;
using System.Linq;

namespace BIM313_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> patientPeopleList = GeneratePatientList(); //Generate patients
            List<HighRiskCovidPatient> highRiskPatientPeopleList = new List<HighRiskCovidPatient>(); //High risk exposure patients
            List<LowRiskCovidPatient> lowRiskPatientPeopleList = new List<LowRiskCovidPatient>(); //Low risk exposure patients
            List<CovidSelfIzolatePatient> covidSelfIzolatePeopleList = new List<CovidSelfIzolatePatient>(); //COVID-19 self isolate people
            List<CovidNegativePeople> covidNegativePeopleList = new List<CovidNegativePeople>(); //COVID-19 negative or inconclusive people
            List<CovidPositivePeople> covidPossitivePeopleList = new List<CovidPositivePeople>(); //COVID-19 positive people
           
            int high_risk_exposure_rate = 30;
            int high_risk_exposure_symptoms_rate = 60;
            int low_risk_exposure_symptoms_rate = 25;
            int laboratory_testing_positive_rate = 30;
            
            Random rnd = new Random();

            // High-Risk and Low-Risk
            for(int i = 0; i < patientPeopleList.Count; i++)
            {
                int random = rnd.Next(1, 100);
                People people = patientPeopleList[i];               
                if (random <= high_risk_exposure_rate) 
                    highRiskPatientPeopleList.Add(new HighRiskCovidPatient(people.name, people.age, people.gender));
                else         
                    lowRiskPatientPeopleList.Add(new LowRiskCovidPatient(people.name, people.age, people.gender));       
            }
            // Self-Izolate and Negative in HighRiskPatients
            for(int i = 0; i < highRiskPatientPeopleList.Count; i++)
            {
                int random = rnd.Next(1, 100);
                HighRiskCovidPatient people = highRiskPatientPeopleList[i];
                if (random <= high_risk_exposure_symptoms_rate)
                    covidSelfIzolatePeopleList.Add(new CovidSelfIzolatePatient(people.name, people.age, people.gender));
                else
                    covidNegativePeopleList.Add(new CovidNegativePeople(people.name, people.age, people.gender));
            }
            // Self-Izolate and Negative in LowRiskPatients
            for(int i = 0; i < lowRiskPatientPeopleList.Count; i++)
            {
                int random = rnd.Next(1, 100);
                LowRiskCovidPatient people = lowRiskPatientPeopleList[i];
                if(random <= low_risk_exposure_symptoms_rate)
                    covidSelfIzolatePeopleList.Add(new CovidSelfIzolatePatient(people.name, people.age, people.gender));
                else
                    covidNegativePeopleList.Add(new CovidNegativePeople(people.name, people.age, people.gender));
            }
            // Laboratory Testing
            for(int i = 0; i < covidSelfIzolatePeopleList.Count; i++)
            {
                int random = rnd.Next(1, 100);
                CovidSelfIzolatePatient people = covidSelfIzolatePeopleList[i];
                if (random <= laboratory_testing_positive_rate)
                    covidPossitivePeopleList.Add(new CovidPositivePeople(people.name, people.age, people.gender));
                else
                    covidNegativePeopleList.Add(new CovidNegativePeople(people.name, people.age, people.gender));
            }
            //Order by age

            covidSelfIzolatePeopleList = covidSelfIzolatePeopleList.OrderBy(p => p.GetAge())
                .ToList();
            covidPossitivePeopleList = covidPossitivePeopleList.OrderBy(p => p.GetAge())
                .ToList();
            covidNegativePeopleList = covidNegativePeopleList.OrderBy(p => p.GetAge())
                .ToList();

            //Print negative            
            foreach (People people in covidNegativePeopleList)
                people.Display();

            //Print positive
            foreach (People people in covidPossitivePeopleList)
                people.Display();
        }
        //Generate patient list
        static List<People> GeneratePatientList()
        {
            #region Generate People list
            List<People> patientPeopleList = new List<People>();
            string name;
            int age, nameIndex, surnameIndex;
            string[] maleNameArr = { "James", "John", "Robert", "Michael", "William", "David", "Richard", "Charles", "Joseph", "Thomas" };
            string[] femaleNameArr = { "Mary", "Patricia", "Linda", "Barbara", "Elizabeth", "Jennifer", "Susan", "Margaret", "Lisa", "Nancy" };
            string[] surnameArr = { "Adams", "Allen", "Anderson", "Atkins", "Baker", "Barnes", "Bell", "Bennet", "Cooper", "Forester",
            "Foster", "Fox", "Gardener", "Hamilton", "Harris", "Marshall", "Murphy", "Parker", "Richardson", "Simpson"};
            //Generate Females
            age = 10;
            for (int i = 0; i < 100; i++)
            {
                nameIndex = i % femaleNameArr.Count();
                surnameIndex = i % surnameArr.Count();
                name = femaleNameArr[nameIndex] + " " + surnameArr[surnameIndex];
                age++;
                if (age > 80)
                {
                    age = 10;
                }
                People newPeople = new People(name, age, "female");
                patientPeopleList.Add(newPeople);
            }
            //Generate Males
            age = 80;
            for (int i = 0; i < 100; i++)
            {
                nameIndex = i % maleNameArr.Count();
                surnameIndex = i % surnameArr.Count();
                name = maleNameArr[nameIndex] + " " + surnameArr[surnameIndex];
                age--;
                if (age < 10)
                {
                    age = 80;
                }
                People newPeople = new People(name, age, "male");
                patientPeopleList.Add(newPeople);
            }
            //Order people by age
            patientPeopleList = patientPeopleList.OrderBy(p => p.GetAge())
            .ToList();
            return patientPeopleList;
            #endregion
        }
    }
}
