using System;

namespace MethodExercise
{
    class Program
    {
        public static string Name()
        {
            string name = Console.ReadLine();
            return name;
        }
        public static string Color()
        {
            string color = Console.ReadLine();
            return color;
        }
        public static string Animal()
        {
            string animal = Console.ReadLine();
            return animal;
        }
        public static string Band()
        {
            string band = Console.ReadLine();
            return band;
        }
         static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Name();
            Console.WriteLine("What is your favorite color?");
            string color = Color();
            Console.WriteLine("What is your favorite animal?");
            string animal = Animal();
            Console.WriteLine("What is your favorite band?");
            string band = Band();

            Console.WriteLine($"It was a warm and {color} day when I decided I wanted to check out the new hot spot in town, {band}. I was intrigued when my server introduced themselves as {name} {animal}.");

         
        }
    }
}
