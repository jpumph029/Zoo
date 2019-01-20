using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Animal
    {
        public abstract int Legs { get; set; }
        public virtual bool Friendly { get; set; } = true;

        public virtual bool Eat()
        {
            Console.Write("I am eating\n");
            return true;
        }
        public abstract bool Speak();
    }
        
}
