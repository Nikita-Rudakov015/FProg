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

            Console.WriteLine(a*b);
            Console.WriteLine(6/4);
            Console.WriteLine(6%4);

            short biiiigInt = 32000;
            short biiiigInt1 = 32000;
           
            unchecked
            {
                short result1 = (short)(biiiigInt + short.Parse("32000"));

            }

            double aD = 3.4;
            double bD = 5.6;

            Console.WriteLine($"Double result is:{ aD * bD -Math.Sqrt(100) / 5}");

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
            Console.WriteLine((char)(aC+1));
        }
    }
}
