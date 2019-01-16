using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Parrot : Birds
    {
        public override string Name { get; set; } = "Picky Parrot";
        public override int Legs { get; set; } = 2;

        public override bool Speak()
        {
            Console.Write($"Parrot: Hello!\n");
            return true;
        }
    }
}
