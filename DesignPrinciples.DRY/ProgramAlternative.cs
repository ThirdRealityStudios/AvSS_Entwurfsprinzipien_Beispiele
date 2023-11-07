using System;

namespace DesignPrinciples.DRY
{
    class ProgramAlternative
    {
        private static string formatQuestion = "Name der {0}. Person";
        private static string formatAnswer = "Hallo {0}, du bist die {1} Person";

        static void MainAlternative(string[] args)
        {
            Console.WriteLine(formatQuestion, 1);
            String nameFirst = Console.ReadLine();
            Console.WriteLine(formatAnswer, nameFirst, "erste");
            Console.WriteLine();

            Console.WriteLine(formatQuestion, 2);
            String nameSecond = Console.ReadLine();
            Console.WriteLine(formatAnswer, nameSecond, "zweite");
            Console.WriteLine();

            Console.WriteLine(formatQuestion, 3);
            String nameThird = Console.ReadLine();
            Console.WriteLine(formatAnswer, nameThird, "dritte");
            Console.WriteLine();

        }


    }
}
