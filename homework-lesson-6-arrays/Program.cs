using System;

namespace homework_lesson_6_arrays
{
    internal class Program
    {
        int[] array = new int[5];
        static void Main(string[] args)
        {
            Program sort = new Program();
            Console.WriteLine($"Random array 0-100");
            sort.GenerateArray();
            sort.PrintArray();

            Console.WriteLine($"\nPlease, input sort by buble: 1-Ascending  2-Descending");
            string choose = Console.ReadLine();
            if(int.TryParse(choose, out int method))
            {
                switch (method)
                {
                    case 1:
                        Console.WriteLine($"\nAscending array 0-100");
                        sort.BubleSortAsc();
                        sort.PrintArray();
                        break;
                    case 2:
                        Console.WriteLine($"\nDesccending array 0-100");
                        sort.BubleSortDesc();
                        sort.PrintArray();
                        break;
                    default:
                        break;
                }
            }
        }

        public void GenerateArray()
        {
            Random random = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = (int)(random.NextDouble() * 100);
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public void BubleSortAsc()
        {
            for(int i = 0;i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void BubleSortDesc()
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
