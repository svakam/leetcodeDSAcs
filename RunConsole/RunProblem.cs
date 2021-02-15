using System;
using leetcodeDSAcs;

namespace RunConsole
{
    class RunProblem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leetcode problems!");
            Console.WriteLine("Choose a problem to run by difficulty, data structure type, or directly by problem name: ");
            Console.WriteLine("If by difficulty, type \"df\"; if by data structure, type \"ds\"; if by problem type, type \"p\". Then press Enter: ");
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
                default:
                    Console.WriteLine("Try again. ");
                    return;
            }
        }

        public static void ChooseByDifficulty(string[] args)
        {
            Console.WriteLine("Choose by difficulty: Easy (e) or Medium (m)");
            switch (Console.ReadLine())
            {
                case "e":
                    Console.WriteLine("Choose a problem by data structure, problem name, or random problem: ");
                    break;
                case "m":
                    Console.WriteLine("Choose a problem by data structure, problem name, or random problem: ");
                    break;
                default:
                    Console.WriteLine("Try again. ");
                    return;
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
