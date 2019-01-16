using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class SeaLion : Aquatic
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
    }
}
