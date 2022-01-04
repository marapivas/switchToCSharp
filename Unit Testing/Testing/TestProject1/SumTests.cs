using System.Collections.Generic;
using Testing.Classes;
using Xunit;

namespace TestProject1
{
    public class SumTests
    {
        [Fact]
        public void SumTests_Pass()
        {
            //[arrange]

            var sum = new Sum();

            //[act]

            List<int> numbers = new List<int> { 1, 2, 3 };

            //[assert]

            Assert.Equal(6, sum.GetSum(numbers));
        }

        [Fact]
        public void SumTests_WithEmptyList()
        {
            //[arrange]

            var sum = new Sum();

            //[act]

            List<int> numbers = new List<int>();

            //[assert]

            Assert.Equal(0, sum.GetSum(numbers));
        }

        [Fact]
        public void SumTests_With1Number()
        {
            //[arrange]

            var sum = new Sum();

            //[act]

            List<int> numbers = new List<int> {1};

            //[assert]

            Assert.Equal(1, sum.GetSum(numbers));
        }

        [Fact]
        public void SumTests_WithListIsNull()
        {
            //[arrange]

            var sum = new Sum();

            //[act]

            List<int> numbers = new List<int>();
            numbers = null;

            //[assert]

            Assert.Equal(0, sum.GetSum(numbers)) ;
        }
    }
}
