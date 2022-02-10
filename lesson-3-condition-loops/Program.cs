using System;

namespace lesson_3_condition_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 6;
            if (a < 5)
            {
                Console.WriteLine($"{a} is less than {b}");
            }
            else
            {
                Console.WriteLine($"{a} is more than {b}");
            }

            string s = a <= 5 ? $"{a} is less than {b}" : $"{a} is more than {b}";
            Console.WriteLine(s);

            int c = a <= b ? a + b : a - b;
            Console.WriteLine(c);

            switch (a)
            {
                case 5:
                    Console.WriteLine("a is 5");
                    break;
                case 6:
                    Console.WriteLine("a is 6");
                    break;
                case 7:
                    Console.WriteLine("a is 7");
                    break;
                default:

                    break;
                    ;
            }
            /*
            string message1 = Console.ReadLine();
            if (float.TryParse(message1, out float digit1))
            {
                //Console.WriteLine(digit + 1);
            }
            else { Console.WriteLine("Input is incorrect"); }
            string message2 = Console.ReadLine();
            if (float.TryParse(message2, out float digit2))
            {
                //Console.WriteLine(digit + 1);
            }
            else { Console.WriteLine("Input is incorrect"); }
            string message3 = Console.ReadLine();
            if (int.TryParse(message3, out int digit3))
            {
                switch (digit3)
                {
                    case 1:
                        Console.WriteLine(digit1 + digit2);
                        break;
                    case 2:
                        Console.WriteLine(digit1 - digit2);
                        break;
                    case 3:
                        Console.WriteLine(digit1 * digit2);
                        break;
                    case 4:
                        Console.WriteLine(digit1 / digit2);
                        break;
                    default:
                        break;
                }
            }
            else { }

            */

            //homework
        }
    }
}
