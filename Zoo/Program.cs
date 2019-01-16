using System;
using Zoo.Classes;
using Zoo.Interfaces;

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
            chester.Fly();
            chester.Land();
            chester.Swim();
            chester.Stop();
            Console.Write("\n");
            whale.Speak();
            whale.Play();
            whale.Swim();
            Console.Write("\n");
            seaLion.Speak();
            seaLion.Play();
            whale.Swim();
            Console.Write("\n");
            parrot.Speak();
            parrot.Fly();
            parrot.Land();
            parrot.Eat();
            Console.ReadKey();
            Console.Write("\n");


            



        }
    }
}
