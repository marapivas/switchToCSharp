using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Classes;
using Xunit;

namespace TestProject1
{
    public class CountLettersTests
    {
        [Fact]
        public void CountLettersTest_Pass()
        {
            //[arrange]

            var countLetters = new CountLetters();
            Dictionary<string, int> expectedKVP = new Dictionary<string, int>();
            expectedKVP.Add("A", 1);
            expectedKVP.Add("h", 1);
            expectedKVP.Add("o", 1);
            expectedKVP.Add("j", 1);
            expectedKVP.Add("a", 2);
            expectedKVP.Add("n", 2);

            //[act]

            string input = "Ahoj anna";

            //[assert]

            Assert.Equal(expectedKVP, countLetters.Frequency(input));
        }
    }
}
