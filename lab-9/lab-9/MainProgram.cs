using System;

namespace lab_9
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5,5];
            Random random = new Random();

            Sorting sortingArray = new Sorting();
            
            Console.Write("Исходный массив: \n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 9);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            array = sortingArray.SortingArray(array);

            Console.Write("\nОтсортированный массив: \n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
