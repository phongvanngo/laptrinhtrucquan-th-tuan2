using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MyUtilityLibraries
{
    public static class StringManipulation
    {
        public static string ReplaceAtIndex(this string word, int i, char value)
        {
            char[] letters = word.ToCharArray();
            letters[i] = value;
            return string.Join("", letters);
        }

        public static string NameStandaldize(this string name)
        //ngo van phong -> Ngo Van Phong
        {
            string[] word_list = name.ToLower().Split(' ');

            for (int i = 0; i < word_list.Length; i++)
            {
                string word = word_list[i];
                word = word.ReplaceAtIndex(0, word[0].ToString().ToUpper()[0]);
                word_list[i] = word;
            }

            return string.Join(" ", word_list);
        }
    }
}
