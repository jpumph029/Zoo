using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Tiger : Feline
    {
        public override int Legs { get; set; } = 4;
        public override bool Friendly { get; set; } = false;

        public override bool Speak()
        {
            Console.Write("Tiger: Roar\n");
            return base.Speak();
        }
        public override bool Eat()
        {
            Console.WriteLine("Tiger *eating*");
            return true;
        }
    }
}
