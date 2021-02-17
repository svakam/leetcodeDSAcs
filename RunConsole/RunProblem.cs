using System;
using leetcodeDSAcs;

namespace RunConsole
{
    class RunProblem
    {
        static void Main(string[] args)
        {
            bool firstTime = true;
            if (firstTime) Console.WriteLine("Leetcode problems!");
            Console.WriteLine("Choose a problem to run by difficulty, data structure type, or directly by problem name. Then press Enter: ");
            Console.WriteLine("Difficulty -- \"df\"");
            Console.WriteLine("Data structure -- \"ds\"");
            Console.WriteLine("Problem name -- \"p\"");
            Console.WriteLine("Random problem -- \"r\"");
            Console.WriteLine("Exit -- \"e\"");
            switch (Console.ReadLine())
            {
                case "df":
                    ChooseByDifficulty(args);
                    break;
                case "ds":
                    ChooseByDataStructure(args);
                    break;
                case "p":
                    ChooseByProblem(args);
                    break;
                case "r":
                    ChooseRandom(args);
                    break;
                case "e":
                    return;
                default:
                    Console.WriteLine("Try again. ");
                    Main(args);
                    break;
            }
        }

        public static void ChooseByDifficulty(string[] args)
        {
            Console.WriteLine("Choose by difficulty:");
            Console.WriteLine("Easy -- \"e\""); 
            Console.WriteLine("Medium -- \"m\"");
            Console.WriteLine("(Go back -- \"b\")");
            Console.WriteLine("(Exit -- \"b\")");
            switch (Console.ReadLine())
            {
                case "e":
                    Console.WriteLine("Choose a problem by data structure, problem name, or random problem: ");
                    break;
                case "m":
                    Console.WriteLine("Choose a problem by data structure, problem name, or random problem: ");
                    break;
                case "b":
                    Main(args);
                    break;
                default:
                    Console.WriteLine("Try again. ");
                    ChooseByDifficulty(args);
                    break;
            }
        }

        public static void ChooseByDataStructure(string[] args)
        {
            Console.WriteLine("bye");
        }

        public static void ChooseByProblem(string[] args)
        {
            Console.WriteLine("oh no");
        }

        public static void ChooseRandom(string[] args)
        {
            Console.WriteLine("Random problem!");
        }
    }
}
