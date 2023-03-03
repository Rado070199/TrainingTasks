using System;
namespace BracketChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string expresion = Console.ReadLine();
            Console.WriteLine(BracketChecker.Solution(expresion));
        }
    }
}