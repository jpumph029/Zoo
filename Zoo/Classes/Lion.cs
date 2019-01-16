
using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Lion : Feline
    {
        public override int Legs { get; set; } = 4;
        public override bool Friendly { get; set; } = false;

        public override bool Speak()
        {
            Console.Write("Lion: Roar\n");
            return base.Speak();
        }
    }
}
