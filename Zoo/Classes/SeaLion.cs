using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class SeaLion : Aquatic, Iswim
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
        public void Swim()
        {
            Console.Write("I am starting to swim\n");
        }

        public void Stop()
        {
            Console.Write("I am not longer swimming\n");
        }
    }
}
