using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {name}. What state do you live in?");
            string place = Console.ReadLine();
            Console.WriteLine($"How many years have you lived in {place}?");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Thanks for the info {name}. It's interesting to know that you have lived in {place} for {years} years. ");
        }
    }
}
