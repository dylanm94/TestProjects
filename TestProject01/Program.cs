using System;

namespace TestProject01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Balgehakt";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WindowHeight = 50;


            Console.WriteLine("Hello, What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Hello " + input + "!");
            Console.WriteLine("Is you name correct?");
            string answer = Console.ReadLine();
            bool namecheck;
            if (answer == "yes" || answer == "Yes")
            {
                namecheck = true;
            }
            else if (answer == "no" || answer == "No")
            {
                namecheck = true;
            }
            else
            {
                Console.ReadLine();
            }
        }
    }
}