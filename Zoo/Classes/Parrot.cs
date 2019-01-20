using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Parrot : Birds , Ifly
    {
        public override string Name { get; set; } = "Picky Parrot";
        public override int Legs { get; set; } = 2;

        public override bool Speak()
        {
            Console.Write($"Parrot: Hello!\n");
            return true;
        }
        public override bool Eat()
        {
            Console.WriteLine("Parrot is eating");
            return true;
        }

        public bool Fly()
        {
            Console.Write("I am starting to fly\n");
            return true;
        }

        public bool Land()
        {
            Console.Write("I am not longer flying\n");
            return true;
        }

    }
}
