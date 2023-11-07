using System;

namespace DesignPrinciples.DRY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name der 1. Person:");
            String nameFirst = Console.ReadLine();
            Console.WriteLine("Hallo {0}, du bist die erste Person.", nameFirst);
            Console.WriteLine();

            Console.WriteLine("Name der 2. Person:");
            String nameSecond = Console.ReadLine();
            Console.WriteLine("Hallo {0}, du bist die zweite Person.", nameSecond);
            Console.WriteLine();

            Console.WriteLine("Name der 3. Person:");
            String nameThird = Console.ReadLine();
            Console.WriteLine("Hallo {0}, du bist die dritte Person.", nameThird);
            Console.WriteLine();

        }


    }
}
