using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine();
            Console.WriteLine("Basic Calculator Interface");
            Console.WriteLine();
            BasicCalculator b = new BasicCalculator();

            Console.WriteLine("Summation Function Result");
            b.sum(30, 10);
            b.display();
            Console.WriteLine();

            Console.WriteLine("Subtraction Function Result");
            b.sub(30, 10);
            b.display();
            Console.WriteLine();

            Console.WriteLine("Multiplication Function Result");
            b.multiplication(30, 10);
            b.display();
            Console.WriteLine();

            Console.WriteLine("Division Function Result");
            b.division(30, 10);
            b.display();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Scientific Calculator Interface");
            Console.WriteLine();
            ScientificCalculator s = new ScientificCalculator();
            Console.WriteLine();

            Console.WriteLine("Division Function Result");
            Console.WriteLine();
            s.division(30, 10);

            Console.WriteLine("Factorial Function Result");
            Console.WriteLine();
            s.factorial(5);
            Console.WriteLine();

        }
    }
}
