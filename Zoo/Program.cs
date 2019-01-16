using System;
using Zoo.Classes;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Tiger tom = new Tiger();
            Lion leon = new Lion();
            Chicken chester = new Chicken();
            Whale whale = new Whale();
            SeaLion seaLion = new SeaLion();
            Parrot parrot = new Parrot();

            tom.Speak();
            tom.Play();
            Console.Write("\n");
            leon.Speak();
            leon.Play();
            Console.Write("\n");
            chester.Speak();
            chester.Eat();
            Console.Write("\n");
            whale.Speak();
            whale.Play();
            Console.Write("\n");
            seaLion.Speak();
            seaLion.Play();
            Console.Write("\n");
            parrot.Speak();
            parrot.Eat();
            Console.ReadKey();

        }
    }
}
