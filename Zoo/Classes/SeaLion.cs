using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class SeaLion : Aquatic
    {
        public override int Legs { get; set; } = 4;
    }
}
