using System;

namespace Workshop.Models
{
    public class Greeting
    {
        Random random = new Random();
        public long Id { get; set; }
        public string Content { get; set; }
 
        public Greeting(long id, string content)
        {
            this.Id = id;
            this.Content = content;
        }

        public Greeting(string content)
        {
            Content = content;
        }

        public Greeting()
        {
        }

        public string GetColor()
        {
            int rndR = random.Next(0, 255);
            int rndG = random.Next(0, 255);
            int rndB = random.Next(0, 255);

            string Color = $"rgb({rndR}, {rndG}, {rndB})";
            return Color;
        }

        public int GetFontSize()
        {
            int rndSize = random.Next(0, 100);
            
            return rndSize;
        }

        //public int FizzbuzzFontSize(int count)
        //{
        //    int FontSize = 16;

        //    if (count % 3 == 0 && count % 5 == 0 && count % 7 == 0)
        //    {

        //        return FontSize = 72;
        //    }
        //    else if (count % 3 == 0 && count % 5 == 0)
        //    {

        //        return FontSize = 48;
        //    }
        //    else if (count % 5 == 0 && count % 7 == 0)
        //    {

        //        return FontSize = 48;
        //    }
        //    else if (count % 5 == 0)
        //    {

        //        return FontSize = 24;
        //    }
        //    else if (count % 7 == 0)
        //    {

        //        return FontSize = 24;
        //    }
        //    else if (count % 3 == 0)
        //    {

        //        return FontSize = 24;
        //    }
        //    else
        //    {
        //        return FontSize;
        //    }
        //}

        public string Fizzbuzz(int count)
        {
            String FBW = "";

            if(count % 3 == 0 && count % 5 == 0 && count % 7 == 0)
            {
                return FBW = "FizzBuzzWoof";
            }
            else if (count % 3 == 0 && count % 5 == 0)
            {
                return FBW = "FizzBuzz";
            }
            else if (count % 5 == 0 && count % 7 == 0)
            {
                return FBW = "BuzzWoof";

            }
            else if (count % 5 == 0 )
            {
                return FBW = "Buzz";

            }
            else if (count % 7 == 0)
            {
                return FBW = "Woof";

            }
            else if (count % 3 == 0)
            {
                return FBW = "Fizz";

            }
            else
            {
                return FBW = count.ToString();
            }
        }

    }
}
