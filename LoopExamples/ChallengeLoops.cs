using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExamples
{
    [TestClass]
    public class ChallengeLoops
    {
        [TestMethod]
        public void LoopChallenge()
        {
            string longWord = "Supercalifragilisticexpialidocious";

            foreach (char letter in longWord)
            {
                Console.WriteLine(letter);
                
                            
            }

                              
        }


        //Conditionals
        [TestMethod]
        public void ConditionalsChallengeWithBonus()
        {
            string longWord = "Supercalifragilisticexpialidocious";

            foreach (char letter in longWord)
            if (letter == 'i')
            {
                Console.WriteLine(letter);
            }
            else if (letter == 'l')
            {
                Console.WriteLine("L");
            }
            else
            {
                Console.WriteLine("Not an i");
            }
            
         }
        [TestMethod]
        public void CountLetters()
        {
            string longWord = "Supercalifragilisticexpialidocious";
            Console.WriteLine(longWord.Length);
        }

    }
}
