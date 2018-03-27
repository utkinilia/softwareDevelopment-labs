using System.Collections.Generic;

namespace lab_9
{
    class Sorting
    {
        private List<int> oneDimensionalArray = new List<int>();

        public int[,] SortingArray(int[,] array)
        {
            Formating(array);
            int z = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = oneDimensionalArray[z];
                    z++;
                }
            }
            return array;
        }

        private List<int> Formating(int[,] array)
        {
            int k = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    oneDimensionalArray.Add(array[i, j]);
                }
            }
            oneDimensionalArray.Sort();
            return oneDimensionalArray;
        }
    }
}
