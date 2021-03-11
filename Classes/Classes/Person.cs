using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Classes
{

    public class Person
    {

        public string FullName
        {
            get
            {
                return $"{FirstName}{LastName}";
            }
        }

        //got rid of methods bc classes don
        //a class is like a cookie cutter

        public string FirstName { get; set; }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                //dividing it to go from days to years
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                //using convert to change totalAgeInYears from double to int
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
            }
        }

        //can use classes as properties with in other classes that are in the same solution
        public Vehicle Transport { get; set; }

        //Constructors
        //builds object
        //pulling down out cookie cutter / user input and sets it
        public Person() { }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
    }
}
