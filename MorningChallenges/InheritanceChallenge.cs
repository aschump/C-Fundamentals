using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MorningChallenges
{
        //Step 1
        public class UserInfo
        {
            //Step 2
            public string FirstName { get; set; }
            public string LastName { get; set; }
            //no setter for ID so only we can set each users ID
            public int ID { get; }
            public DateTime DateOfBirth { get; set; }


            //Step3
            //must put blank construct before making you own
            public UserInfo()
        {

        }
            public UserInfo(string firstName, string lastName, int iD, DateTime dateOfBirth)
            {
                FirstName = firstName;
                LastName = lastName;
                ID = iD;
                DateOfBirth = dateOfBirth;
            }

            //Bonus
            public string FullName
            {
                get
                {
                    return $"{FirstName}{LastName}";
                }

            }

            //Double Bonus

            public int Age(DateTime birthdate)
            {
                TimeSpan ageSpan = DateTime.Now - birthdate;
                double AgeInYears = ageSpan.TotalDays / 365.25;
                //converting AgeinYears to an int  
                int years = Convert.ToInt32(Math.Floor(AgeInYears));
                return years;
            }


        }

    }

