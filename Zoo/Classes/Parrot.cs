using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Parrot : Birds , Ifly
    {
        public override string Name { get; set; } = "Picky Parrot";
        public override int Legs { get; set; } = 2;

        public override bool Speak()
        {
            Console.Write($"Parrot: Hello!\n");
            return true;
        }

        public void Fly()
        {
            Console.Write("I am starting to fly\n");
        }

        public void Land()
        {
            Console.Write("I am not longer flying\n");
        }
    }
}
