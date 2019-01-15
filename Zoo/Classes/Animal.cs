using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Animal
    {
        public int Legs { get; set; }
        public bool Friendly { get; set; }

        public virtual bool Eat()
        {
            Console.Write("I am eating");
            return true;
        }
        public abstract bool Speak();
    }
        
}
