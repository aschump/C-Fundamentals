using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    [TestClass]
    public class Switch
    {
        enum WeekDay {  Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday}

        [TestMethod]
        public void SwitchCases()
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    //break is important bc it symbolizes case 1 is done and to go to case 2
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                //good to have a default but you don't have to
                //without a default nothing will happen if neither case is met
                default:
                    Console.WriteLine("This is a default: it will execute if no case is met");
                    break;

            }

            WeekDay today = WeekDay.Wednesday;

            switch(today)
            {
                case WeekDay.Monday:
                case WeekDay.Tuesday:
                case WeekDay.Wednesday:
                case WeekDay.Thursday:
                case WeekDay.Friday:
                    Console.WriteLine("Hope you are ready to work!!");
                    break;
                case WeekDay.Saturday:
                case WeekDay.Sunday:
                    Console.WriteLine("Sorry we are closed");
                    break;
            }

            int age = 37;
            switch (age)
            {
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                case 22:
                case 23:
                    break;
                default:
                    break;

            }
        }
        [TestMethod]
        public void SwitchExpressions()
        {
            string output;
            int action = 1;

            switch (action)
            {
                case 0:
                    output = "Case 0";
                    break;
                case 1:
                    output = "Case 1";
                    break;
                case 2:
                    output = "Case 2";
                    break;
                default:
                    output = "Default Case";
                    break;

            }
        }
     }
}
