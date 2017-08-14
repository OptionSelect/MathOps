using System;

namespace MathOps
{
    class Program
    {
        public static double Sum(double x, double y) => x + y;
        public static double Difference(double x, double y) => x - y;
        public static double Multiply(double x, double y) => x * y;
        public static double Division(double x, double y) => x / y;
        public static double Remainder(double x, double y) => x % y;

        public static void ShowResults(double num1, double num2, double sum, double difference, double multiplication, double division, double remainder)
        {
            Console.WriteLine($"The result of {num1} plus {num2} was: {sum}.");
            Console.WriteLine($"The result of {num1} minus {num2} was: {difference}.");
            Console.WriteLine($"The result of {num1} multiplied by {num2} was: {multiplication}.");
            Console.WriteLine($"The result of {num1} divided by {num2} was: {division}.");
            Console.WriteLine($"The remainder of {num1} divided by {num2} was: {remainder}.");
        }
        static void Main(string[] args)
        {
            Console.Write("Hello, Please Enter Number 1: ");
            var num1 = double.Parse(Console.ReadLine());
            Console.Write("Great! Please Enter Number 2: ");
            var num2 = double.Parse(Console.ReadLine());

            var sum = Sum(num1, num2);
            var difference = Difference(num1, num2);
            var multiplication = Multiply(num1, num2);
            var division = Division(num1, num2);
            var remainder = Remainder(num1, num2);

            ShowResults(num1, num2, sum, difference, multiplication, division, remainder);
        }
    }
}
