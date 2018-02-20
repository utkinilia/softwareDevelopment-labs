using System;

namespace lab_2
{
    class RemovingSpaces
    {
        public static string Delete(string text)
        {
            int i = 0;
            do
            {
                if (text[i] == ' ' && text[i + 1] == ' ')
                    text = text.Remove(i, 1);
                else
                    i++;
            }
            while (i < text.Length);
            return text;
        }
    }
}