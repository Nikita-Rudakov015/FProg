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

            /*Console.WriteLine($"\nPlease, input sort by buble: 1-Ascending  2-Descending");*/
            Console.WriteLine($"\n\nBuble sort ascending array 0-100");
            sort.BubleSortAsc();
            sort.PrintArray();

            Console.WriteLine($"\n\nBuble sort desccending array 0-100");
            sort.BubleSortDesc();
            sort.PrintArray();

            Console.WriteLine($"\n\nSelection sort ascending array 0-100");
            sort.SelectionSortAsc();
            sort.PrintArray();

            Console.WriteLine($"\n\nSelection sort desccending array 0-100");
            sort.SelectionSortDesc();
            sort.PrintArray();
            
            Console.WriteLine($"\n\nInsertion sort ascending array 0-100");
            sort.InsertionSortAsc();
            sort.PrintArray();

            Console.WriteLine($"\n\nInsertion sort desccending array 0-100");
            sort.InsertionSortDesc();
            sort.PrintArray();
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
            for (int i = 0; i < array.Length; i ++)
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

        public void SelectionSortAsc()
        {
            for(int i = 0; i < array.Length - 1; i ++)
            {
                int iMin = i; 
                for(int j = i + 1; j < array.Length; j ++)
                {
                    if(array[j] < array[iMin])
                    {
                        iMin = j;
                    }
                }
                int tmp = array[iMin];
                array[iMin] = array[i];
                array[i] = tmp;
            }   
        }

        public void SelectionSortDesc()
        {
            for (int i = 0; i < array.Length - 1; i ++)
            {
                int iMin = i;
                for (int j = i + 1; j < array.Length; j ++)
                {
                    if (array[j] > array[iMin])
                    {
                        iMin = j;
                    }
                }
                int tmp = array[iMin];
                array[iMin] = array[i];
                array[i] = tmp;
            }
        }

        public void InsertionSortAsc()
        {
            for (int i = 1; i < array.Length; ++i)
            {
                int key = array[i];
                int j = i - 1;

                // Move elements of array[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }
        
        public void InsertionSortDesc()
        {
            for (int i = 1; i < array.Length; ++i)
            {
                int key = array[i];
                int j = i - 1;

                // Move elements of array[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && array[j] < key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }
    }
}
