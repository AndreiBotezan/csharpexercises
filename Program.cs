using System;

namespace csharpexercises
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(SwapTwoNumbers(1, 2));
        }
        public static double AddAndMultiply(double a, double b, double c)
        {
            return (a + b) * c;
        }
        public static string CtoF(double T)
        {
            double F = T * 1.8 + 32;
            if (T < -271.15)
            {
                return "Temperature below absolute zero!";
            } else
            {
                return $"T = {F}F";
            }
        
        }
        public static string ElementaryOperations(double a, double b)
        {
            double add = a + b;
            double substract = a - b;
            double multiply = a * b;
            double div;

            if (b == 0)
            {
                div = 0;
            } else
                div = a / b;

            return string.Format($"a+b={add}, a-b={substract}, " +
                $"a*b={multiply}, a/b={div}");
        }
        public static bool IsResultTheSame(double a, double b)
        {
            return a == b;
        }
        public static int ModuloOperations(int a, int b, int c)
        {
            return a % b % c;
        }
        public static double TheCubeOf(double a)
        {
            return a * a * a;
        }
        public static string SwapTwoNumbers(double a, double b)
        {
            string before = $"Before: a = {a}, b = {b}; ";
            double x = a;
            a = b;
            b = x;

            string after = $"After: a = {a}, b = {b}";
            return before + after;
        }
    }
}
