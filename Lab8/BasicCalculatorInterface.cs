using System;
namespace Lab8
{
    interface BasicCalculatorInterface
    {
        int sum(int x, int y);
        int sub(int x, int y);
        int multiplication(int x, int y);
        int division(int x, int y);
    }
    class BasicCalculator : BasicCalculatorInterface
    {
        int result;

        public int sum(int num1, int num2)

        {
            Console.WriteLine("Summation: " + num1 + "+" + num2);
            result = num1 + num2;
            return result;
        }

        public int sub(int num1, int num2)

        {
            Console.WriteLine("Subtraction: " + num1 + "-" + num2);
            result = num1 - num2;
            return result;
        }

        public int multiplication(int num1, int num2)

        {
            Console.WriteLine("Multiplication: " + num1 + "*" + num2);
            result = num1 * num2;
            return result;
        }

        public int division(int num1, int num2)

        {
            Console.WriteLine("Division: " + num1 + "%" + num2);
            result = num1 / num2;
            return result;
        }

        public void display()

        {
            Console.WriteLine("Result: " + result);
        }
    }
}