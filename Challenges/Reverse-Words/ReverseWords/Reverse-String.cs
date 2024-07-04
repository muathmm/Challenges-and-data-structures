using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    public class Reverse_String
    {

        public static string ReverseWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            List<string> words = new List<string>();
            int start = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    words.Add(input.Substring(start, i - start));
                    start = i + 1;
                }
            }
           
            words.Add(input.Substring(start));

         
            for (int i = 0, j = words.Count - 1; i < j; i++, j--)
            {
                string temp = words[i];
                words[i] = words[j];
                words[j] = temp;
            }

           
            string result = string.Empty;
            for (int i = 0; i < words.Count; i++)
            {
                result += words[i];
                if (i < words.Count - 1)
                {
                    result += " ";
                }
            }

            return result;
        }
    }
}
