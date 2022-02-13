using System;

namespace lesson_data_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            short s = 300;
            int us = -234234;

            int i = 5;
            int result = ++i + i++;
            Console.WriteLine(result);

            bool isTrue = true;
            Console.WriteLine(!isTrue);

            Console.WriteLine(a * b);
            Console.WriteLine(6 / 4);
            Console.WriteLine(6 % 4);

            short biiiigInt = 32000;
            short biiiigInt1 = 32000;

            unchecked
            {
                short result1 = (short)(biiiigInt + short.Parse("32000"));

            }

            double aD = 3.4;
            double bD = 5.6;

            Console.WriteLine($"Double result is:{ aD * bD - Math.Sqrt(100) / 5}");

            Console.WriteLine(a << b);
            Console.WriteLine(16 >> 100);

            int aA = 4;
            int bB = 10;

            Console.WriteLine(!(aA == bB));

            bool aBool = false;
            bool bBool = true;
            Console.WriteLine("\n", aBool | bBool);//true
            Console.WriteLine(aBool || bBool);//true

            aA = aA + 10;
            aA += 10;
            Console.WriteLine(aA);


            double d = 3.213113;
            Console.WriteLine(Math.Pow(d, 2));
            Console.WriteLine(Math.Sign(d));

            var now = DateTime.Now;
            Console.WriteLine(now);
            var yesterday = now.AddDays(-1);
            Console.WriteLine((now - yesterday).TotalSeconds);


            char aC = 'a';
            Console.WriteLine((char)(aC + 1));



            //homework
            byte byt = 100;
            short so = 150;
            long l = 1000;
            bool fiB = false;
            bool seB = true;
            char cr = 'c';
            float f = 45;
            double de = 45.4342;
            string str = "Saturday";


            int x = -30;
            int y = 60;

            Console.WriteLine($"Homework\nThe first example: { -6 * (Math.Pow(x, 3)) + 5 * (Math.Pow(x, 2)) - 10 * x + 15}");
            Console.WriteLine($"The second example: {Math.Abs(x) * Math.Sin(x)}");
            Console.WriteLine($"The 3-id example: {2 * Math.PI * x}");
            Console.WriteLine($"The 4-th example: {Math.Max(x, y)}");
        }
    }
}
