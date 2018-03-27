using System;
using System.Collections.Generic;

namespace lab_8
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            List<List<int>> array = new List<List<int>>();
            array.Add(new List<int>() { 5, 10, -1 });
            array.Add(new List<int>() { 1, -6, 9 });
            array.Add(new List<int>() { 4, 6, -3, });

            Console.Write("Исходный массив: \n");
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array[i].Count; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

            AddRow addRow = new AddRow();

            array.Add(addRow.Add(array));

            Console.Write("\nРезультат: \n");
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array[i].Count; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}