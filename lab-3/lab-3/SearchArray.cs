using System.Collections.Generic;

namespace lab_3
{
    class SearchArray
    {
        public List<int> searchSameElements(List<int> array)
        {
            List<int> result = new List<int>();
            int count = 1;
            int number = array[0];
            for (int i = 1; i < array.Count; i++)
            {
                if (array[i] == number)
                    count++;
                else
                {
                    result.Add(count);
                    count = 1;
                    number = array[i];
                }
            }
            result.Add(count);
            return result;
        }
    }
}