using System.Collections.Generic;
using Testing.Classes;
using Xunit;

namespace TestProject1
{
    public class ExtensionTests
    {
        Extension extension = new Extension();

        //[Fact]
        //public void TestAdd_2and3is5()
        //{
        //    Assert.Equal(5, extension.Add(2, 3));
        //}

        //[Fact]
        //public void TestAdd_1and4is5()
        //{
        //    Assert.Equal(5, extension.Add(1, 4));
        //}

        //[Fact]
        //public void TestMaxOfThree_First()
        //{
        //    Assert.Equal(5, extension.MaxOfThree(5, 4, 3));
        //}

        //[Fact]
        //public void TestMaxOfThree_Fhird()
        //{
        //    Assert.Equal(5, extension.MaxOfThree(3, 4, 5));
        //}

        //[Fact]
        //public void TestMedian_Four()
        //{
        //    Assert.Equal(5, extension.Median(new List<int>() { 7, 5, 3, 5 }));
        //}

        //[Fact]
        //public void TestMedian_Five()
        //{
        //    Assert.Equal(3, extension.Median(new List<int>() { 1, 2, 3, 4, 5 }));
        //}

        //[Fact]
        //public void TestIsVowel_a()
        //{
        //    Assert.Equal(extension.IsVowel('a'));
        //}

        //[Fact]
        //public void TestIsVowel_u()
        //{
        //    Assert.Equal(extension.IsVowel('u'));
        //}

        //[Fact]
        //public void testTranslate_bemutatkozik()
        //{
        //    Assert.Equal("bevemuvutavatkovozivik", extension.Translate("bemutatkozik"));
        //}

        //[Fact]
        //public void testTranslate_kolbice()
        //{
        //    Assert.Equal("lavagovopuvus", extension.Translate("lagopus"));
        //}

        //New Tests

        [Fact]
        public void TestAdd_4and3is7()
        {
            Assert.Equal(7, extension.Add(4, 3));
        }

        [Fact]
        public void TestAdd_10and4is14()
        {
            Assert.Equal(14, extension.Add(10, 4));
        }

        [Fact]
        public void TestMaxOfThree_First()
        {
            Assert.Equal(10, extension.MaxOfThree(10, 8, 3));
        }

        [Fact]
        public void TestMaxOfThree_Second()
        {
            Assert.Equal(7, extension.MaxOfThree(3, 7, 5));
        }

        [Fact]
        public void TestMaxOfThree_Fhird()
        {
            Assert.Equal(6, extension.MaxOfThree(3, 4, 6));
        }

        [Fact]
        public void TestMedian_Six()
        {
            Assert.Equal(4, extension.Median(new List<int>() { 1, 2, 3, 5, 7, 8 }));
        }

        [Fact]
        public void TestMedian_Five()
        {
            Assert.Equal(4, extension.Median(new List<int>() { 2, 3, 4, 5, 9 }));
        }

        [Fact]
        public void TestIsVowel_a()
        {
            Assert.True(extension.IsVowel('a'));
        }

        [Fact]
        public void TestIsVowel_u()
        {
            Assert.True(extension.IsVowel('u'));
        }

        [Fact]
        public void TestIsVowel_b()
        {
            Assert.False(extension.IsVowel('b'));
        }

        [Fact]
        public void testTranslate_bemutatkozik()
        {
            Assert.Equal("bevemuvutavatkovozivik", extension.Translate("bemutatkozik"));
        }

        [Fact]
        public void testTranslate_kolbice()
        {
            Assert.Equal("kovolbiviceve", extension.Translate("kolbice"));
        }
    }
}
