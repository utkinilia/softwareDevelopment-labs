using System;
using System.Collections.Generic;
using System.IO;

namespace lab_10
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            AddZero addZero = new AddZero();
            List<double> array = new List<double>();
            StreamReader read = new StreamReader("input.txt");

            string line;

            while ((line = read.ReadLine()) != null)
            {
                array.Add(Convert.ToDouble(line));
            }

            array = addZero.addZero(array);

            StreamWriter write = new StreamWriter("output.txt");

            for (int i = 0; i < array.Count; i++)
            {
                write.Write(array[i] + " ");
            }

            write.Close();

            Console.Read();
        }
    }
}
