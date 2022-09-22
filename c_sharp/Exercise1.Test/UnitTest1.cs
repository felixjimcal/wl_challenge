using exercise1;

namespace Exercise1.Test
{
    public class Tests
    {
        Twiner twiner;

        [SetUp]
        public void Setup()
        {
            twiner = new Twiner();
        }

        [Test]
        public void TestSameLengthFalse()
        {
            string a = "abc", b = "abcd";
            Assert.False(twiner.CheckTwins(a,b));
        }

        [Test]
        public void TestSameLengthTRUE()
        {
            string a = "abc", b = "abc";
            Assert.True(twiner.CheckTwins(a, b));
        }

        [Test]
        public void TestAllLowerCase()
        {
            string a = "aBc", b = "AbC";
            Assert.True(twiner.CheckTwins(a, b));
        }

        [Test]
        public void TestAllCharsSorted()
        {
            string a = "cBa", b = "acB";
            Assert.True(twiner.CheckTwins(a, b));
        }

        [Test]
        public void TestLowerSortedAndSameFALSE()
        {
            string a = "cBa", b = "dba";
            Assert.False(twiner.CheckTwins(a, b));
        }

        [Test]
        public void TestLowerSortedAndSameTRUE()
        {
            string a = "cBa", b = "bca";
            Assert.True(twiner.CheckTwins(a, b));
        }
    }
}