using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ValueTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Booleans()
        {
            //this is declared, if not intialized its default is false
            bool isDeclared;
            isDeclared = true;

            //declaring and initializing in same line
            bool isDeclaredAndInitialized = false;

            //second value will trump first value
            isDeclaredAndInitialized = true;
        }
    }
    
    [TestMethod]
    public void Characters()
    {
        //use single quotation mark to initialize char variable
        char character = 'a';
        char symbol = '?';
        char numbers = '7';
        char space = ' ';
        char specialCharacter = '\n';
    }


    [TestMethod]
    public void WholeNumbers()
    {
        //max that it can hold is 255
        byte byteExample = 255;
        //max it can hold is 127
        sbyte sByteExample = 127;
        //max holds is +-32767
        short shortExample = 32767;
        //
        Int16 anotherShortExample = 32000;
        //
        int intMin = 2147483647;
        Int32 intMax = 2147483647;
        long longExample = 9223372036854775807;
        Int64 longMin = -9223372036854775807;

        int a = 15;
        int b = -15;

        byte age = 25;

    }

 
    [TestMethod]
    public void Decimals()
    {
        //wont work if you don't add the letter at end (i.e., 'f', 'm', 'd')
        float floatExample = 1.045231f;
        double doubleExample = 1.789053278907036d;
        decimal decimalExample = 1.2578907289045789789789789787897m;

        Console.WriteLine(floatExample);
        Console.WriteLine(doubleExample);
        Console.WriteLine(decimalExample);
        
    }

    enum PastryType { Cake, Cupcake, Eclaire, Petitfour, Croissant }
    [TestMethod]
    public void Enums()
    {
        //put values in to use later.
                PastryType myPastry = PastryType.Croissant;
        PastryType anotherOne = PastryType.Cake;

    }

    [TestMethod]
    public void Structs()
    {
        //PRE BUILT META DATE THAT ALLOWS YOU TO BRING IN SPECIFIC INFO (like todays date)
        DateTime today = DateTime.Today;

        //birthday has to be written Year, Month, Date
        DateTime birthday = new DateTime(1800, 6, 20);

        Console.WriteLine(today);

    }
}
