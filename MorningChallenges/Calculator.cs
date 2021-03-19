using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallenges
{
    public class Calculator
    {

        int NumOne = 6;
        int NumTwo = 2;

        public int Add(int NumOne, int NumTwo)
        {
            int sum = NumOne + NumTwo;
            return sum;
        }
        // whole numbers and decimals/create an overloaded method
        public double Add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }
        
        public int Subtract (int NumOne, int NumTwo)
        {
            int difference = NumOne - NumTwo;
            return difference;
        }

        public int Multiply (int NumOne, int NumTwo)
        {
            int product = NumOne * NumTwo;
            return product;
        }
        public int Divide (int NumOne, int NumTwo)
        {
            int quotient = NumOne / NumTwo;
            return quotient;
        }

    }
    //Test Methods
    [TestClass]
    public class CalculatorTestClass
    {
        //private double numThree?
        //make another method that can take doubles?

        private int numOne = 27;
        private int numTwo = 3;

        //for whole number and decimals
        private double numThree = 1.5;
        private double numFour = 2.6;
        Calculator calculate = new Calculator();

        [TestMethod]
        public void TestingAdditionMethodShouldReturnTrue()
        {
            //moved this up
            //Calculator calculate = new Calculator();
            //--------
            var sumTwo = calculate.Add(numOne,NumTwo);
            var sum = calculate.Add(numThree, NumFour);
           
            //int sum = calculate.Add(numOne, numTwo);
            //Assert.AreEqual(sum, (numOne + numTwo));
            //for whole number and decimals

            Assert.AreEqual(sum, (numThree + numFour));
            Assert.AreEqual(sumTwo, (numOne + numTwo));
        }

        //testmethod for substraction
        //testmethod for others




    }
}
