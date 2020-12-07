using AoC2020.Days;
using NUnit.Framework;

namespace AoC2020.Test
{
    public class Day7
    {
        private string testData;
        private IDays _day;

        [SetUp]
        public void Setup()
        {
            testData = "Day7_TestData.txt";
            _day = new Days.Day7();
        }

        [TestCase("4")]
        public void Test1(string expectedResult)
        {
            var result = _day.PartOne(testData);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("6")]
        public void Test2(string expectedResult)
        {
            var result = _day.PartTwo(testData);
            Assert.AreEqual(expectedResult, result);
        }

    }
}