using System;

namespace DesignPrinciples.DRY
{
    class ProgramAlternative2
    {
        private static string formatQuestion = "Name der {0}. Person";
        private static string formatAnswer = "Hallo {0}, du bist die {1} Person";

        static void MainAlternative(string[] args)
        {
            askPerson(1, "erste");
            askPerson(2, "zweite");
            askPerson(3, "dritte");
        }


        private static void askPerson(int num, string position)
        {
            Console.WriteLine(formatQuestion, num);
            String name = Console.ReadLine();
            Console.WriteLine(formatAnswer, name, position);
            Console.WriteLine();

        }


    }
}
