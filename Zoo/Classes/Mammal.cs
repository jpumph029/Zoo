using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammal : Animal
    {
        public virtual bool BreathsAir { get; set; }
        public abstract bool Play();
    }
}
