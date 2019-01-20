using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Feline : Mammal
    {
        public override bool Speak()
        {
           
            return true;
        }
        public override bool Play()
        {
            Console.Write("I am playing\n");
            return true;
        }
    }
}
