using System;
using System.Collections.Generic;

namespace Testing.Classes
{
    public class Extension
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int MaxOfThree(int a, int b, int c)
        {
            if (a > b && a > c)
                return a;
            else if (b > c && b > c)
                return b;
            else
                return c;
        }

        public int Median(List<int> pool)
        {
            if (pool.Count % 2 == 0)
            {
                return (pool[pool.Count / 2 - 1] + pool[pool.Count / 2]) / 2;
            }
            else
            {
                return pool[(pool.Count - 1) / 2];
            }
            
        }

        public bool IsVowel(char c)
        {
            return (new List<char>() { 'a', 'u', 'o', 'e', 'i' }).Contains(c);
        }

        public string Translate(string hungarian)
        {
            string teve = hungarian;
            int length = teve.Length;
            for (int i = 0; i < length; i++)
            {
                char c = teve[i];
                if (IsVowel(c))
                {
                    teve = string.Join(c + "v" + c, teve.Split(c));
                    i += 2;
                    length += 2;
                }
            }

            return teve;
        }
    }
}
