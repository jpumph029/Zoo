using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Birds : Animal
    {
        public abstract string Name { get; set; }
        public virtual bool CanFly { get; set; } = true;
    }
}
