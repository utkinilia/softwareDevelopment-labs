using System;
using System.Collections.Generic;

namespace lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveFromArray removeFromArray = new RemoveFromArray();
            List<double> array = new List<double>();

            Console.WriteLine("Введите количество элементов: ");
            int amountOfElements = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfElements; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива: ");
                double element = double.Parse(Console.ReadLine());
                array.Add(element);
            }

            array = removeFromArray.DeleteElement(array);

            Console.WriteLine("Результат: ");
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.Read();
        }
    }
}