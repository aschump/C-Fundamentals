using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Calculator
    {
        //access modifier  return type  method signature(paremeters)
        //method signature = name of the method
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }
        public void Add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }
        public int CalculateAge(DateTime birthdate)
        {
            TimeSpan ageSpan = DateTime.Now - birthdate;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            //converting totalAgeinYears to an int  
            //douln eis rounding it down (flooring it)
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }
}    