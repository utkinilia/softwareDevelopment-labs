using System;

namespace lab1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            SeparatingDigits stringNumbers = new SeparatingDigits();
            Console.WriteLine("Введите шестизначное число: ");
            int number = int.Parse(Console.ReadLine());
            string result = stringNumbers.separation(number);
            Console.WriteLine($"Сумма первых 3 десятичных цифр {result} сумме 3 последних десятичных цифр");
            Console.Read();
        }
    }
}