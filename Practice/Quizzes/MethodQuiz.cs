using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Practice
{
    [TestClass]
    public class UnitTest1
    {
        public class Quiz
        {
            //Question 5
            //Write method that takes in two numbers of type int, divides the first 
            //by the second, and then returns the quotient as a double.
            public int Divide(int NumberOne, int NumberTwo)
            {
                int quotient = NumberOne / NumberTwo;
                int quotientDouble = NumberOne % NumberTwo;
                return quotientDouble;
            }

            //Question 6
            //Write a method that takes in a number and writes out every number from 1 until the given number.
            //If the number is divisible by 3 write Fizz instead.
            //If the number is divisible by 5 write Buzz instead.
            //If the number is divisible by both write FizzBuzz instead.

            [TestMethod]
            public void WordNum(int num)

            {
                if (userNum % 3 == 0)

                {
                    Console.WriteLine("Fizz");
                }
                else if (userNum % 5 == 0)

                {
                    Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine("FizBuzz");
                }
            }

            //Question 7
            //Write a method that takes in a birthday and writes
            //to the console how old the user is.

            public void UserBday(int userBday)
            {       

                int userBday;

                int userAge = DateTime.today - userBday;

                return userAge;

            }

            //Question 8
            //Write a method that takes in a name and then writes
            //out a greeting with the name included
            public void HeyThere(string userName)

            {

                string userName;

                Console.WriteLine("Hey there " + userName + "! Hope your day is as awesome as you are.");

            }

            //Question 9
            //Write a method that takes in two numbers and outputs whichever one is the largest.
            public void BiggestNumber(int numberOne, int numberTwo)
            {
                if (numberOne > numberTwo)
                {
                    Console.WriteLine(numberOne);
                }
                else
                {
                    Console.WriteLine(numberTwo);
                }

            }

            //Question 10
            //Write a method that takes in a string and returns the parsed value as an integer.
            ///can't remember, will have to review

            public void StringNum ()
            {
                public int StringNum(wordNum)
                {
                string moreWords = int.Parse(wordNum);

                }
            }


        }
    }

    }


    }
}
