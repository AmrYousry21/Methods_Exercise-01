using System;

namespace Methods_Exercise_01_Answers
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.PrintGreeting();
            Program.AddSpaces();
            Program.SayHello("Amr", "Yousry");
            Program.AddSpaces();
            Program.GreetUser();
            Program.AddSpaces();
            Program.Exponentiate();
            Program.AddSpaces();
            Program.IsPrime();
        }

        public static void AddSpaces() 
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

        public static void PrintGreeting() 
        {
            Console.WriteLine("Hello World");
        }

        public static void SayHello(string firstName, string LastName) 
        {
            Console.WriteLine($"Hello, {firstName} {LastName}!");
        }

        public static void GreetUser() 
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }

        public static void Exponentiate() 
        {
            Console.WriteLine("Enter first number:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter PowerOf number:");
            int powerOf = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Pow(num, powerOf));
        }

        public static void IsPrime() 
        {
            Console.WriteLine("Enter number to check if prime:");
            int num = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {
                Console.WriteLine("{0} is a Prime Number", num);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }

    }
}
