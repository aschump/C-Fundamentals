using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arithmetic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            //Addition '+'
            //Make a container(type int) call it 'sum' and set it equal to desired value
            int sum = a + b;
            sum += 3;

            Console.WriteLine($"sum: {sum}");

            //Substraction '-'
            int difference = a - b;
            //difference-=3; (notes)

            Console.WriteLine($"difference: {difference}");

            //Multiplication '*'
            int product = a + b;
            //product*=3;
            Console.WriteLine($"product: {product}");

            //division '/'
            int quotient = a / b;
            Console.Write($"quotient: {quotient}");

            //Modulus
            //remainder when we divide two numbers
            int remainder = a % b;
            Console.WriteLine($"remainder: {remainder}");

            DateTime now = DateTime.Now;
            DateTime someday = new DateTime(1978, 1, 1);

            //use TimeSpan (a struct[structs are immutable])
            TimeSpan timeSpan = now - someday;
            Console.WriteLine(timeSpan.Days);
            Console.WriteLine(timeSpan.TotalMilliseconds);

        }
    }
}
