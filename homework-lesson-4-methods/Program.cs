using System;

namespace homework_lesson_4_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please, choose method: 1-5");
            string choose = Console.ReadLine();
            if (int.TryParse(choose, out int method))
            {
                switch (method)
                {
                    case 1:
                        //first method
                        Console.WriteLine($"Max value.Please, input two numbers: ");
                        int max_a = int.Parse(Console.ReadLine());
                        int max_b = int.Parse(Console.ReadLine());
                        MaxValue(max_a, max_b);
                        break;
                    case 2:
                        //second method
                        Console.WriteLine($"\nMin value.Please, input two numbers: ");
                        int min_a = int.Parse(Console.ReadLine());
                        int min_b = int.Parse(Console.ReadLine());
                        MinValue(min_a, min_b);
                        break;
                    case 3:
                        //third method
                        Console.WriteLine($"\nSum of numbers between inputs are odd or even.Please, input two numbers: ");
                        int TrySumIfOdd_a = int.Parse(Console.ReadLine());
                        int TrySumIfOdd_b = int.Parse(Console.ReadLine());
                        TrySumIfOdd(TrySumIfOdd_a, TrySumIfOdd_b);
                        break;
                    case 4:
                        //fourh method (Max)
                        Console.WriteLine($"\nMax value with three arg.Please, input three numbers: ");
                        int max_a_3arg = int.Parse(Console.ReadLine());
                        int max_b_3arg = int.Parse(Console.ReadLine());
                        int max_c_3arg = int.Parse(Console.ReadLine());
                        MaxValue(max_a_3arg, max_b_3arg, max_c_3arg);

                        Console.WriteLine($"\nMax value with four arg.Please, input four numbers: ");
                        int max_a_4arg = int.Parse(Console.ReadLine());
                        int max_b_4arg = int.Parse(Console.ReadLine());
                        int max_c_4arg = int.Parse(Console.ReadLine());
                        int max_d_4arg = int.Parse(Console.ReadLine());
                        MaxValue(max_a_4arg, max_b_4arg, max_c_4arg, max_d_4arg);
                        break;
                    case 5:
                        //fourh method (Min)
                        Console.WriteLine($"\nMin value with three arg.Please, input three numbers: ");
                        int min_a_3arg = int.Parse(Console.ReadLine());
                        int min_b_3arg = int.Parse(Console.ReadLine());
                        int min_c_3arg = int.Parse(Console.ReadLine());
                        MinValue(min_a_3arg, min_b_3arg, min_c_3arg);

                        Console.WriteLine($"\nMin value with four arg.Please, input four numbers: ");
                        int min_a_4arg = int.Parse(Console.ReadLine());
                        int min_b_4arg = int.Parse(Console.ReadLine());
                        int min_c_4arg = int.Parse(Console.ReadLine());
                        int min_d_4arg = int.Parse(Console.ReadLine());
                        MinValue(min_a_4arg, min_b_4arg, min_c_4arg, min_d_4arg);
                        break;
                    default:
                        break;
                }
            }
        }
        static int MaxValue(int a, int b)
        {
            if (a > b)
            {
                Console.Write($"The max value is: {Math.Max(a, b)}");
            }
            else if (a < b)
            {
                Console.Write($"The max value is: {Math.Max(a, b)}");
            }
            return 0;
        }

        static int MinValue(int a, int b)
        {
            if (a < b)
            {
                Console.Write($"The min value is: {Math.Min(a, b)}");
            }
            else if (a > b)
            {
                Console.Write($"The min value is: {Math.Min(a, b)}");
            }
            return 0;
        }

        static bool TrySumIfOdd(int a, int b, int c = 0)
        {
            c = a + b;
            if (c % 2 == 1)
            {
                Console.WriteLine($"Sum is odd number: {c}");
                return true;
            }
            else if (c % 2 == 0)
            {
                Console.WriteLine($"Sum is even number: {c}");
                return false;
            }
            return true;
        }

        static int MaxValue(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Console.Write($"The max value is: {a}");
            }
            else if (b > a && b > c)
            {
                Console.Write($"The max value is: {b}");
            }
            else if (c > a && c > b)
            {
                Console.Write($"The max value is: {c}");
            }
            return 0;
        }

        static int MaxValue(int a, int b, int c, int d)
        {
            if (a > b && a > c && a > d)
            {
                Console.Write($"The max value is: {a}");
            }
            else if (b > a && b > c && b > d)
            {
                Console.Write($"The max value is: {b}");
            }
            else if (c > a && c > b && c > d)
            {
                Console.Write($"The max value is: {c}");
            }
            else if (d > a && d > b && d > c)
            {
                Console.Write($"The max value is: {d}");
            }
            return 0;
        }
        static int MinValue(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Console.Write($"The min value is: {a}");
            }
            else if (b > a && b > c)
            {
                Console.Write($"The min value is: {b}");
            }
            else if (c > a && c > b)
            {
                Console.Write($"The min value is: {c}");
            }
            return 0;
        }

        static int MinValue(int a, int b, int c, int d)
        {
            if (a > b && a > c && a > d)
            {
                Console.Write($"The min value is: {a}");
            }
            else if (b > a && b > c && b > d)
            {
                Console.Write($"The min value is: {b}");
            }
            else if (c > a && c > b && c > d)
            {
                Console.Write($"The min value is: {c}");
            }
            else if (d > a && d > b && d > c)
            {
                Console.Write($"The min value is: {d}");
            }
            ///.,
            return 0;
        }
    }
}