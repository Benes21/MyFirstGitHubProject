using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Calculator ==");
            Console.Write("Operand1: ");
            double operand1 = double.Parse(Console.ReadLine());
            Console.Write("Operand2: ");
            double operand2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Solution = {operand1 / operand2}");
            Console.WriteLine($"Sum = {operand1 + operand2}");
        }
    }
}
