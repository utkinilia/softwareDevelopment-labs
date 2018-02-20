using System;

namespace lab_2
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            RemovingSpaces a = new RemovingSpaces();
            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();
            if (String.IsNullOrEmpty(text))
            {
                Console.WriteLine("Ошибка! Вы не ввели текст");
            }
            else
            {
                string result = RemovingSpaces.Delete(text);
                Console.WriteLine("\nРезультат: ");
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
