using System;

namespace lab_4
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            SwapNumbers obj = new SwapNumbers();
            int[] array = new int[] { 4, 5, 6, 7, -12, -3, 4, -5, -7, 2 };

            Console.Write("Исходный массив: \n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            SwapNumbers.swap(array);

            Console.Write("\n\nРезультат: \n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
