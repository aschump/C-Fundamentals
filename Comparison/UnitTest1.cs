using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Comparison
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            //comparison operators allow us to compare on thing to another
            //start with out variables
            int age = 25;
            string userName = "Mick";

            //check to see if something is = to something else
            bool equals = age == 41; // ==
            Console.WriteLine(equals);
            //container (userIsTerry will see if userName Terry matches the string userName
            //that is above
            bool userIsTerry = userName == "Terry";
            Console.WriteLine(userIsTerry);
            //should be false because age = 25
            Console.WriteLine("User is 41" + equals);

            //using the '!'(bang) operator!
            //'!=' means not equal
            bool notEqual = age != 122;
            Console.WriteLine($"User is not 122: {notEqual}");

            bool userIsNotJustin = userName != "Justin";
            Console.WriteLine(userIsNotJustin);

            //firstList.Count could equal secondlist.Count, but the actual Lists are 
            //not the same list.
            //two different names same content

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            //compare the list
            bool listAreEqual = firstList.Count == secondList.Count ;
            Console.WriteLine($"The list are equal?: {listAreEqual}");

            //greater than
            //boolean expression plugged into a conditional
            bool greaterThan = age > 12;

            //greater than or equal to
            bool greaterThanOrEqual = age >= 24;
            Console.WriteLine(greaterThanOrEqual);

            //less than
            bool lessThan = age < 66;
            Console.WriteLine(lessThan);

            //less than or equal to
            bool lessThanOrEqualTo = age <= 24;
            Console.WriteLine(lessThanOrEqualTo);

            //or '||'
            bool orValue = equals || lessThan;

            bool trueValue = true;
            bool falseValue = false;
            //is more useful when getting into logic, if statements
            //name is container
            
            bool tOrT = trueValue || falseValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;

            //() ---> methodCall
            Console.WriteLine($"True or True { tOrT}: "); 
            Console.WriteLine($"True or False { tOrF}: "); 
            Console.WriteLine($"False or True { fOrT}: "); 
            Console.WriteLine($"False or False { fOrF}: ");

            // and '&&'
            bool andValue = greaterThan && orValue;

            bool tAndT = trueValue && trueValue; //true
            bool tAndF = trueValue && falseValue; //false
            bool fAndT = falseValue && trueValue; //false
            bool fAndF = falseValue && falseValue; //false



        }
    }
}
