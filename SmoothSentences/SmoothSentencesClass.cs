using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoothSentences
{
    public static class SmoothSentencesClass
    {
        public static bool CheckSentence(string sentence)
        {
            string word = "";
            char lastLetter;
            for (int i = 0; i < sentence.Length; i++)
            {
                char c = sentence[i];

                if (c == ' ')
                {
                    lastLetter = word.Last();
                    if (sentence[i + 1] != lastLetter)
                    {
                        return false;
                    }
                    word += c;
                }
                else
                {
                    word += c;
                }
            }

            return true;
        }
    }
}
