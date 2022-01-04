using Testing.Classes;
using Xunit;

namespace TestProject1
{
    public class ApplesTest
    {
        [Fact]
        public void AppleTest()
        {
            //[arrange]

            var apple = new Apples();

            //[act]

            //[assert]
            Assert.Equal("apple", apple.GetApple());

        }

        [Fact]
        public void AppleTest_Fail()
        {
            //[arrange]

            var apple = new Apples();

            //[act]

            //[assert]

            Assert.DoesNotMatch("pear", apple.GetApple());

        }

    }
}
