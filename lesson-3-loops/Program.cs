using System;

namespace lesson_3_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, input number X: ");
            string numX = Console.ReadLine();
            if (int.TryParse(numX, out int digitX))
            {

            }
            else { Console.WriteLine("Input is incorrect"); }
            Console.WriteLine("Please, input number Y: ");
            string numY = Console.ReadLine();
            if (int.TryParse(numY, out int digitY))
            {

            }
            else { Console.WriteLine("Input is incorrect"); }

            if(digitX < digitY)
            {
                int i, count = 0, Sum = 0;
                for (i = digitX; i <= digitY; i++)
                {
                    count = i;
                    Sum += count;
                    Console.Write($"+{i}");
                }
                Console.Write($"\n Sum = {Sum}");
            }
            if(digitX > digitY)
            {
                int i, count = 0, Sum = 0;
                for (i = digitY; i <= digitX; i++)
                {
                    count = i;
                    Sum += count;
                    Console.Write($"+{i}");
                }
                Console.Write($"\n Sum = {Sum}");
            }
            if(digitX == digitY)
            {
                int i, count = 0, Sum = 0;
                for (i = digitY; i <= digitX; i++)
                {
                    count = i;
                    Sum += count;
                }
                Console.Write($"\n Sum = {Sum}");
            }



            //Хотел сделать проверку на ввод через цикл
            /*
            Console.WriteLine("Please, input a number Y:");
            string Y = Console.ReadLine();
            bool Yb = float.TryParse(Y, out float digitY);
            while (Yb == false)
            {
                Console.WriteLine("Incorrect input");
                Console.ReadLine();
            }
            Console.WriteLine("Good");
            GetUserNumberX();*/
        }
        //Хотел сделать проверку на ввод 
       /* public static int GetUserNumberX()
        {
            int userNumX;
            Console.WriteLine("Please, enter integer number: ");
            string userInputX = Console.ReadLine();
            bool parseAnswerX;
            parseAnswerX = int.TryParse(userInputX, out userNumX);
            if (parseAnswerX == false)
            {
                Console.WriteLine("Please, valid integer: ");
                return userNumX;
            }
            return userNumX;



            int userNumY;
            Console.WriteLine("Please, enter integer number: ");
            string userInputY = Console.ReadLine();
            bool parseAnswerY;
            parseAnswerY = int.TryParse(userInputY, out userNumY);
            if (parseAnswerY == false)
            {
                Console.WriteLine("Please, valid integer: ");
                return userNumY;
            }
            return userNumY;
        }*/
    }
}
