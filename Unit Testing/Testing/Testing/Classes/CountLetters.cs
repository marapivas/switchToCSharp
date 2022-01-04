using System;
using System.Collections.Generic;

namespace Testing.Classes
{
    public class CountLetters
    {
        public Dictionary<string, int> Frequency(string input)
        {
            Dictionary<string, int> frequency = new Dictionary<string,int>();
            char[] chars = input.ToCharArray();

            foreach (var ch in chars)
            {
                if(!ch.Equals(' '))
                {
                    if (!frequency.ContainsKey(Convert.ToString(ch)))
                    {
                        frequency.Add(Convert.ToString(ch), 1);
                    }
                    else
                    {
                        int value = frequency.GetValueOrDefault(Convert.ToString(ch));
                        frequency.Remove(Convert.ToString(ch));
                        frequency.Add(Convert.ToString(ch), ++value);
                    }
                }
                
            }

            return frequency;
        }
    }
}
