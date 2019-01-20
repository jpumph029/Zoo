using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Birds : Animal
    {
        public abstract string Name { get; set; }
        public virtual bool CanFly { get; set; } = true;
    }
}
