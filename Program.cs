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
        public static int Addition(int x, int y)
        {
            int sum = x+y;
            return sum;
        }
        public static int Subtraction(int x, int y)
        {
            int difference = x-y;
            return difference;
        }
        public static int Multiply(int x, int y)
        {
            int total = x*y;
            return total;
        }
        public static int Divide(int x, int y)
        {
            int equals = x / y;
            return equals;
        }
        public static int Mod(int x, int y)
        {
            int remainder = x % y;
            return remainder;
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

           
            int sum = Addition(6, 8);
            Console.WriteLine(sum);
            int diff = Subtraction(12, 4);
            Console.WriteLine(diff);
            int total = Multiply(5, 12);
            Console.WriteLine(total);
            int equals = Divide(12, 3);
            Console.WriteLine(equals);
            int remainder = Mod(14, 5);
            Console.WriteLine(remainder);
         
        }
    }
}
