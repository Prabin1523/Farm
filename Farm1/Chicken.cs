using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{

    public class Chicken : Animal
    

    {
        public void Eat() // This method describes what animal eats
        {
            Console.WriteLine("Chicken eat worms");

        }

        public void NumberOfLegs() // This method describes how many legs does animal have
        {
            Console.WriteLine("Chicken has two legs");

        }

        public void Speak() //This method describes how animal produce their sound
        {
            Console.WriteLine("Chicken says Quack Quack");

        }

        public void Use() //This method describes what is the use of the animal. 
        {
            Console.WriteLine("Pig eat everything");

        }
        
    }
}
