using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Pig(); new Cow(); new Goat(); new Chicken();
            Console.WriteLine("Choose from the following options: ");
            Console.WriteLine("Chicken, Pig, Cow, Goat: ");
            string userInput = Console.ReadLine();

            Chicken myChicken = new Chicken();
            if (userInput == "Chicken" || userInput == "chicken")
               
            {
                myChicken.Eat();
                myChicken.NumberOfLegs();
                myChicken.Speak();
                myChicken.Use();
            }
           else if ( userInput == "Pig" || userInput == "pig")
            {
                Pig myPig = new Pig();
                myPig.Eat();
                myPig.NumberOfLegs();
                myPig.Speak();
                myPig.Use();

            }
            else if (userInput == "Cow" || userInput == "cow")
            {
                Cow myCow = new Cow();
                myCow.Eat();
                myCow.NumberOfLegs();
                myCow.Speak();
                myCow.Use();
            }

            else if (userInput == "Goat" || userInput == "goat")
            {
                Goat myGoat = new Goat();
                myGoat.Eat();
                myGoat.NumberOfLegs();
                myGoat.Speak();
                myGoat.Use();

            }
            else
            {
                Console.WriteLine("Wrong Input");
            }

        }

        
    }
}
