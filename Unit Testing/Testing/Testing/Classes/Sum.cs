using System.Collections.Generic;

namespace Testing.Classes
{
    public class Sum
    {
        public int GetSum(List<int> numbers)
        {
            int sum = 0;

            if (numbers != null)
            {
                foreach (int number in numbers)
                {
                    sum += number;
                }
                return sum;
            }    
            else
            {
                return 0; 
            }
            
        }
    }
}
