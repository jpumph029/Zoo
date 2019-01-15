using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Aquatic : Mammal
    {
        public virtual bool Migrate()
        {
            Console.Write("I am not migrating\n");
            return false;
        }
    }
}
