using System;
using System.Collections.Generic;

namespace lab_3
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            SearchArray obj = new SearchArray();
            List<int> array = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива: ");
                int element = int.Parse(Console.ReadLine());
                array.Add(element);
            }

            array = obj.searchSameElements(array);

            Console.WriteLine("\nРезультат: ");
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadLine();
        }
    }
}