using System;
using System.Collections.Generic;

namespace lab_5
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            AddZero addZero = new AddZero();
            List<double> array = new List<double>();
            Console.WriteLine("Введите число элементов массива: ");
            int numbersElements = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersElements; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива: ");
                double element = double.Parse(Console.ReadLine());
                array.Add(element);
            }

            array = addZero.addZero(array);

            Console.WriteLine("Результат: ");
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Read();
        }
    }
}
