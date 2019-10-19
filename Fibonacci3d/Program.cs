using System;

namespace Fibonacci3d
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Series and the position for nth Fibonacci number with space: ");
            string length = Console.ReadLine();
            while (string.IsNullOrEmpty(length) || length.Split(' ').Length < 2 || !int.TryParse(length.Split(' ')[0], out int n) || !int.TryParse(length.Split(' ')[1], out int n2))
            {
                Console.WriteLine("Enter the length of the Fibonacci Series and the position for nth Fibonacci number with space: ");
                length = Console.ReadLine();
            }
            Console.WriteLine(Environment.NewLine);
            CalculateFibonacciOne(Convert.ToInt32(length.Split(' ')[0]));
            CalculateFibonacciTwo(Convert.ToInt32(length.Split(' ')[0]));

            Console.WriteLine("Position of Nth Fibonacci number");
            var startDate = DateTime.Now;
            Console.WriteLine($"Position {Convert.ToInt32(length.Split(' ')[1])} Fibonacci number is {NthFibonacciNumber(Convert.ToInt32(length.Split(' ')[1]) - 1)}");
            var endDate = DateTime.Now;
            Console.WriteLine($"Time spent: {(endDate - startDate).TotalMilliseconds} ms.");


            Console.ReadKey();
        }

        public static void CalculateFibonacciOne(int len)
        {
            Console.WriteLine("Iterative");
            var startDate = DateTime.Now;
            int a = 0, b = 1, c = 0;
            Console.Write($"{a} {b}");
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write($" {c}");
                a = b;
                b = c;
            }
            var endDate = DateTime.Now;
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Time spent: {(endDate - startDate).TotalMilliseconds} ms.");
            Console.WriteLine(Environment.NewLine);
        }

        public static void CalculateFibonacciTwo(int len)
        {
            Console.WriteLine("Recursive");
            var startDate = DateTime.Now;

            Fibonacci_Rec_Temp(0, 1, 1, len);

            var endDate = DateTime.Now;
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Time spent: {(endDate - startDate).TotalMilliseconds} ms.");
            Console.WriteLine(Environment.NewLine);
        }
        private static void Fibonacci_Rec_Temp(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.Write($"{a} ");
                Fibonacci_Rec_Temp(b, a + b, counter + 1, len);
            }
        }

        public static int NthFibonacciNumber(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return (NthFibonacciNumber(n - 1) + NthFibonacciNumber(n - 2));
            }
        }

    }
}
