using System.Collections.Generic;

namespace lab_8
{
    class AddRow
    {
        public List<int> Add(List<List<int>> array)
        {
            List<int> newArray = new List<int>();
            for (int i = 0; i < array.Count; i++)
            {
                int sum = Search(i, array);
                for (int j = 0; j < array[i].Count; j++)
                {
                    if (array[i][j] < 0)
                    {
                        newArray.Add(sum);
                    }
                }
            }
            return newArray;
        }

        private int Search(int i, List<List<int>> array)
        {
            int sum = 0;
            for (int j = 0; j < array[i].Count; j++)
            {
                if (array[i][j] > 0)
                {
                    sum += array[i][j];
                }
            }
            return sum;
        }

    }
}