using System;

namespace lesson_6_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;
            int[] array = new int[N];
            int[] array1 = new[] { 1, 2, 3, 4, 5 };
            int[] array2 = { 1, 2, 3, 4, 5 }; 
        
            array[0] = 18;
            array[1] = 34;
            array[6] = 12;

            int i = 0;

            for(i = 0; i < N; i++)
            {   
                int value = array[i];
                array[i] = i;
            }

            for(i = 0; i < N; i++)
            {
                Console.WriteLine($"{i} item of array is { array[i]}");
            }

            Console.WriteLine("-------------------------");

            for(i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"{i} item of array is { array1[i]}");
            }

            Console.WriteLine("-------------------------");

            i = 0;
            foreach (int item in array2)
            {
                Console.WriteLine($"{i++} Item of array is {item}");
            }

            Console.WriteLine("-------------------------");
            int multiplier = 0;
            var copiedArray = Copy(array);
            MultipleByNumber(array, multiplier);

            i = 0;
            foreach (int item in copiedArray)
            {
                Console.WriteLine($"{i++} Item of array is {item}");
            }
            Console.WriteLine(multiplier);

            Console.WriteLine("-------------------------");
            InitArray(10, 20);

            foreach (int item in InitArray(10,20))
            {
                Console.WriteLine($"{i++} Item of array is {item}");
            }


            Console.WriteLine("-------------------------");
            var random = new Random();
            int[] randomArray = new int[N];
            for (i = 0; i < N; i++)
            {
                randomArray[i] = random.Next(10);
            }

            foreach (int item in randomArray)
            {
                Console.WriteLine($"{i++} Item of array is {item}");
            }

            Console.WriteLine("-------------------------");

            var random1 = new Random();
            int[] randomArray1 = new int[N];
            for (i = 0; i < N; i++)
            {
                randomArray[i] = random.Next(10);
            }

            foreach (int item in randomArray)
            {
                Console.WriteLine($"{i++} Item of array is {item}");
            }



        }

        //Вставка
        // 2, 6, 5, 1
        // 1, 2, 6, 5
        // 1, 2, 5, 6


        //Пузырек
        // 2, 6, 5, 1
        // 2, 5, 1, 6
        // 2, 1, 5, 6
        // 1, 2, 5, 6
        static int[] Sort(int[] array)
        {
            //количество проходов
            for (int i = 0; i < array.Length; i++)
            {
                //сравнения каждого елемента
                for (int j = 0; j < array.Length; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        
                        int temp = array[j + 1];
                        array[j + 1] = array[j + 1];
                        array[j + 1] = temp;
                    }
                   
                }
            }
            return array;
        }



        static int[] InitArray(int a, int b)
        {
            int[] init = new int [b - a];
            Console.WriteLine($"array length is {init.Length}");
            for (int i = 0; i < init.Length; i++)
            {
                init[i] = a++;
            }
            return init;
        }



        static int[] Copy(int[] array)
        {
            int[] copy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i];
            }
            return copy;
        }

        //side efect
        static int[] MultipleByNumber(int[] array, int multiplier)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= multiplier;
            }

            multiplier = 10;
            return array;
        }
    }     
}
