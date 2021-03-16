using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Greeter
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello,{name}!");
                    }
    public void SayHello()
    {
        Console.WriteLine("Hello");
    }
        Random _random = new Random();
        public void GetRandomGreeting()
        {
            string[] availableGreetings = new string[] { "Good Morning", "What's up", "Whats up Dawg", "Howdy" };
            //the .length will make it choose within the correct amount of available greeting
            //anything after the comma says stop at certain number
            int randomNumber = _random.Next(0, availableGreetings.Length);
            //element matches the number to the greeting
            string randomGreeting = availableGreetings.ElementAt(randomNumber);
            
            Console.WriteLine($"{Random.Greeting}");
        }
    }

}
