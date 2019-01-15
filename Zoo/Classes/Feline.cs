using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Feline : Mammal
    {
        public override bool Speak()
        {
            Console.Write("I am roaring");
            return true;
        }
        public override bool Play()
        {
            Console.Write("I am playing");
            return true;
        }
    }
}
