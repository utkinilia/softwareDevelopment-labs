using System;

namespace lab_4
{
    class SwapNumbers
    {
        static public int[] swap(int[] array)
        {
            int positiveElement = array[0];
            int negativeElement = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < positiveElement)
                {
                    positiveElement = array[i];
                }
                else if (array[i] < 0 && array[i] < negativeElement)
                {
                    negativeElement = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == positiveElement)
                {
                    array[i] = negativeElement;
                }
                else if (array[i] == negativeElement)
                {
                    array[i] = positiveElement;
                }
            }
            return array;
        }
    }
}
