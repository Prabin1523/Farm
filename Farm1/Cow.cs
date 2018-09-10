using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Cow : Animal
   

    {
        public void Eat()// This method describes what animal eats
        {
            Console.WriteLine("Cow eats Hay");

        }

        public void NumberOfLegs() // This method describes how many legs does animal have
        {
            Console.WriteLine("Cow has Four Legs");

        }

        public void Speak() //This method describes how animal produce their soun
        {
            Console.WriteLine("Cow says Moo");

        }

        public void Use() //This method describes what is the use of the animal. 
        {
            Console.WriteLine("Cow is good source of Milk");

        }
        
    }
}
