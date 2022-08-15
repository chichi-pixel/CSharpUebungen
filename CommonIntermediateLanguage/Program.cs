using System;

namespace CommonIntermediateLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me your name!");
            var name = Console.ReadLine();

            Console.WriteLine($"Oh, nice!, {name}. Your age?");

            var ageAsText = Console.ReadLine();

            if(int.TryParse(ageAsText, out int age))
            {
                Console.WriteLine($"Forever young, only {age}?");
            }

            else
            {
                Console.WriteLine($"Sorry, i didn't get!");
            }

            Console.WriteLine("Well, it was nice to meet you! Ciao ciao!");
            Console.ReadKey();
        }
    }
}
