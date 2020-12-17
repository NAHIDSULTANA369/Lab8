using System;
namespace Lab8
{
    interface ScientificCalculatorInterface
    {
        int XtoY(int x, int y);
        double division(double x, double y);
        int factorial(int x);
    }
    class ScientificCalculator : ScientificCalculatorInterface
    {
        double result;
        public double division(double num1, double num2)

        {
            Console.WriteLine("Division: " + num1 + "%" + num2);
            if (num1 % num2 == 0)
            {
                result = num1 / num2;
                Console.WriteLine("Result: " + result);
                return 0;
            }
            else
            {
                int a = Convert.ToInt32(num1 / num2);
                double b = num1 % num2;
                result = num1 / num2;
                Console.WriteLine("Result: " + result);
                Console.WriteLine("Quotient = " + a + "  &  Remainder = " + b);
                return 0;

            }
        }
        public int factorial(int number)

        {
            Console.WriteLine("Factorial Of Number: " + number);
            int fact = 1;
            for (int x = 1; x <= number; x++)
            {
                fact *= x;
            }
            int r = fact;
            Console.WriteLine("Result: " + r);
            return 0;

        }

        public void SwapNum(ref int x, ref int y)

        {

            int tempswap = x;
            x = y;
            y = tempswap;
        }

        public int XtoY(int a, int b)

        {
            Console.WriteLine("Value of X and Y before swapping");
            Console.WriteLine("X=" + " " + a);
            Console.WriteLine("Y=" + " " + b);

            SwapNum(ref a, ref b);

            Console.WriteLine();
            Console.WriteLine("Value of X and Y after swapping");
            Console.WriteLine("X=" + " " + a);
            Console.WriteLine("Y=" + " " + b);
            Console.ReadLine();
            return 0;
        }

        public void display()
        {
            Console.WriteLine("Result: " + result);
        }
    }
}
