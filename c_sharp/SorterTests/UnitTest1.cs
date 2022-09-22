using Exercise2;

namespace SorterTests
{
    [TestFixture]
    public class Tests
    {
        Sorter sorter;
        [SetUp]
        public void Setup()
        {
            sorter = new Sorter();
        }

        [Test]
        public void Number0ReturnAllText()
        {
            int number = 0;
            string actual = "a bc def", result = "";
            string expectedResult = actual;

            result = sorter.SortCharacters(number, actual);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void RemoveWhiteSpaces()
        {
            int number = 1;
            string actual = "a bc def", result = "", expectedResult = "a\nb\nc\nd\ne\nf\n";

            result = sorter.SortCharacters(number, actual);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void SortDuos()
        {
            int number = 2;
            string actual = "a bc def", result = "", expectedResult = "ab\ncd\nef\n";

            result = sorter.SortCharacters(number, actual);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}