using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm

{
    
    public class Goat : Animal
    {
        public void Eat() // This method describes what animal eats
        {
            Console.WriteLine("Goat eats Grass");

        }

        public void NumberOfLegs() // This method describes how many legs does animal have
        {
            Console.WriteLine("Goat has four legs");

        }

        public void Speak() //This method describes how animal produce their soun
        {
            Console.WriteLine("Goat sys Meh");

        }

        public void Use()//This method describes what is the use of the animal. 
        {
            Console.WriteLine("Goat is good source of Meat");

        }
        
    }
}
