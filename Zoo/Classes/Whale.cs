﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Whale : Aquatic
    {
        public override int Legs { get; set; } = 0;

        public override bool Play()
        {
            Console.Write("I am not playing.\n");
            return false;
        }

        public override bool Speak()
        {
            Console.Write("*Whale noises*\n");
            return true;
        }
    }
}
