using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Whale : Aquatic, Iswim 
    {
        public override int Legs { get; set; } = 0;

        public override bool Play()
        {
            Console.Write("I am not playing.\n");
            return false;
        }

        public override bool Speak()
        {
            Console.Write("Whale: Whale noises\n");
            return true;
        }

        public void Stop()
        {

        }

        public void Swim()
        {
        }
    }
}
