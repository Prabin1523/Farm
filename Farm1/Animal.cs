using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm

{
    /*
    Farm -> Animal -> 4Species -> Speak, Use, Eat, NumberOfLegs
   */

    // This is an Animal interface. All animal will derive from animal interfa
    public interface Animal
    {

       void Speak();
        void Use();
        void Eat();
        void NumberOfLegs();

    }
}
