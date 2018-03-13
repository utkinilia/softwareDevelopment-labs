using System;
using System.Collections.Generic;

namespace lab_5
{
    class AddZero
    {
        public List<double> addZero(List<double> array)
        {
            double sum = Math.Abs(array[0]) + Math.Abs(array[1]) + Math.Abs(array[array.Count - 1]);

            for (int i = 0; i < array.Count; i++)
            {
                if (sum % array[i] == 0)
                {
                    array.Insert(i + 1, 0);
                }
            }
            return array;
        }
    }
}
