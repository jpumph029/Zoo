using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Chicken : Birds
    {
        public override string Name { get; set; } = "Chester";
        public override int Legs { get; set; } = 2;

        public override bool Speak()
        {
            Console.Write($"Chicken: Cheep Cheep\n");
            return true;
        }
        public override bool Eat()
        {
            Console.Write($"{Name} is not hungry\n"); 
            return false;
        }
    }
}
