using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 24;
            int output1 = 0;
            // if a is even increment output1 by one

            if (a % 2 == 0) { output1++; }

            Console.WriteLine(output1);

            int b = 13;
            string output2 = "";
            // if b is between 10 and 20 set output2 to "Sweet!"
            // if less than 10 set output2 to "Less!",
            // if more than 20 set output2 to "More!"

            if (b <= 20 && b >= 10) { output2 = "Sweet!"; }
            else if (b < 10) { output2 = "Less!"; }
            else { output2 = "More!"; }

            Console.WriteLine(output2);

            int c = 123;
            int credits = 100;
            bool isBonus = false;
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same

            if (credits >= 50 && isBonus == false) { c -= 2; }
            else if (credits < 50 && isBonus == false) { c--; }

            Console.WriteLine(c);

            int d = 8;
            int time = 120;
            string output3 = "";
            // if d is dividable by 4
            // and time is not more than 200
            // set output3 to "check"
            // if time is more than 200
            // set output3 to "Time output"
            // otherwise set output3 to "Run Forest Run!"

            if (d % 4 == 0 && time <= 200) { output3 = "check"; }
            else if (time > 200) { output3 = "Time output"; }
            else { output3 = "Run Forest Run!"; }

            Console.WriteLine(output3);
        }
    }
}