using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ReferenceTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Strings()
        {
            string name;
            string declared;
            declared = "this is initialized.";

            string declareAndInitialize = "This is both declaring and initializing.";

            string firstName = "Amber";
            string lastName = "Schumpert";

            string concatenatedFullName = firstName + " " + lastName;

            string interpolationFullName = $"{ firstName} {lastName}";

            string compositeFullName = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(interpolationFullName);
            Console.WriteLine(compositeFullName);


        }
        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";
            //an array is used to store multiple values in a single variable
            string[] stringArray = { "Hello", "World!", "Why", "is it", "always", stringExample };

            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);

            //another way to change part of the array

            stringArray[0] = "Hey There";
            Console.WriteLine(stringArray[0]);

            //Lists
            //line 53 created new list
            List<string> listOfStrings = new List<string>();
            List<int> listOfInts = new List<int>();
            //light blue means variable is being used

            //calling list of string on line 58
            listOfStrings.Add("First string for out list");
            listOfInts.Add(123456);

            Console.WriteLine(listOfInts[0]);

            //Queues
            //an ordered list, starting with first element
            // will only return the first item 
            //example: a great use would be if there were a help line where you want to ensure
            //that the customer that calls in first is helped first

            Queue<string> firstInFirstOut = new Queue<string>();

            firstInFirstOut.Enqueue("I'm First");
            firstInFirstOut.Enqueue("I'm Next");

            //to get them to pop up in console
            //Dequeue will read out queue
            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);

            //Dictionaries

            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            //Used the key, which is 7, to unlock the value, which is "Agent"

            keyAndValue.Add(7, "Agent");

            string valueSeven = keyAndValue[7];
            Console.WriteLine(valueSeven);

            //Sorted List
            //a mix of list and dictionary

            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();

            //Hash set
            HashSet<int> uniqueList = new HashSet<int>();

            //Stack
            Stack<string> lastInFirstOut = new Stack<string>();

            //Classes


        }
        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();

            int randomNumber = rng.Next();

            Console.WriteLine(randomNumber);
        }
    }
}
