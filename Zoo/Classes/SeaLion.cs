using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class SeaLion : Aquatic, Iswim
    {
        public override int Legs { get; set; } = 4;
        public override bool Play()
        {
            Console.Write("I am not playing.\n");
            return false;
        }

        public override bool Speak()
        {
            Console.Write("Sea Lion: BARK BARK\n");
            return true;
        }
        public override bool Eat()
        {
            Console.WriteLine("Sealion *eating*");
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
