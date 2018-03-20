using System.Collections.Generic;

namespace lab_6
{
    public class RemoveFromArray
    {
        public List<double> DeleteElement(List<double> array)
        {
            double average = ArithmeticMean(array);

            for (int i = array.Count - 1; i >= 0; i--)
            {
                if (array[i] > average)
                {
                    array.Remove(array[i]);
                }
            }

            return array;
        }

        private double ArithmeticMean(List<double> array)
        {
            double sum = 0;

            for (int i = 0; i < array.Count; i++)
            {
                sum += array[i];
            }

            double average = sum / array.Count;
            return average;
        }
    }
}
