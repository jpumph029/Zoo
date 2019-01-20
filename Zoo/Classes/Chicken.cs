using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Chicken : Birds, Ifly, Iswim
    {
        public override string Name { get; set; } = "Chester";
        public override int Legs { get; set; } = 2;

        public override bool Speak()
        {
            Console.Write($"Chicken: Cheep Cheep\n");
            return true;
        }
        public override bool Eat()
        {
            Console.Write($"{Name} is not hungry\n"); 
            return false;
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
        public bool Swim()
        {
            Console.Write("I am starting to swim\n");
            return true;
        }

        public bool Stop()
        {
            Console.Write("I am not longer swimming\n");
            return true;
        }
    }
}
