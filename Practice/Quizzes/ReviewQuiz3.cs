using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Quizzes
{
    class ReviewQuiz3
    {
        //Write a method that takes in a birthday and writes to the
        //console how old the user is.
        public int UserBirthday(int birthday)
        {

            int userAge = DateTime.Today - birthday;

            Console.WriteLine($"User is {userAge} years old.");
        }

        //Write a method that takes in two numbers and outputs whichever one is the largest.

        public int BigNum(int numOne, int numTwo)
        {

            if (numOne > numTwo)
            {

                Console.WriteLine(numOne);

            }

            else
            {

                Console.WriteLine(numTwo)


            }

        }
        //Write a method that takes in a string and returns the parsed value as an integer.
        public int SwitchType(string userInput)
        {

            string inputNum = Convert.ToInt32(userInput);

            return inputNum;

        }
        //Write a method that takes in two numbers of type int, divides the first 
        //by the second, and then returns the quotient as a double.
        public double MathStuff(int numOne, int numTwo)
        {

            int numDivided = (numOne / numTwo);

            double finalNum = double.Parse((numOne / numTwo));

            return finalNum;

        }

        //Write a method that takes in a name and then writes out a greeting 
        //with the name included.
        public string HeyUser(string userName)
        {

            string userName = Console.ReadLine();

            string userGreetings = ($"Hey there {userName}! How are you today?");

            return userGreetings;

        }
        //Write a method that takes in a number and writes out every number from 
        //1 until the given number.

        // If the number is divisible by 3 write Fizz instead.
        //If the number is divisible by 5 write Buzz instead.
        //If the number is divisible by both write FizzBuzz instead.
        public int Numbers(int userNum)
        {

            if (userNum % 3 == 0)
            {

                Console.WriteLine = ("Fizz");

            }

            else if (userNum % 5 == 0)
            {

                Console.WriteLine = ("Buzz");

            }

            else if (userNum % 3 == 0 && userNum % 5 == 0)
            {

                Console.WriteLine = ("FizzBuzz");

            }

            else
            {

                Console.WriteLine = ("");

            }
        }
    }
}
