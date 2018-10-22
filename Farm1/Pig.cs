using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{

    public class Pig : Animal
   
    {
        public void Eat() // This method describes what animal eats
        {
            Console.WriteLine("Pig eat everything");

        }

        public void NumberOfLegs() // This method describes how many legs does animal have
        {
            Console.WriteLine("Pig has 4 leg");
        }

        public void Speak() //This method describes how animal produce their soun
        {
            Console.WriteLine("Pig says Wiwi");

        }

        public void Use()//This method describes what is the use of the animal. 
        {
            Console.WriteLine("Pig is good source of meat");
          
        }
        
    }
}
