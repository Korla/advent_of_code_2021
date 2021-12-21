using NUnit.Framework;

namespace aoc2021.Day2Part1;

public class Day2Part1
{
    private int Run(int current1, int current2)
    {
        var score1 = 0;
        var score2 = 0;
        var i = 1;
        while(true)
        {
            current1 = (current1 + (i + 1) * 3 - 1) % 10 + 1;
            score1 += current1;
            i += 3;
            if (score1 >= 1000) return score2 * (i - 1);
            current2 = (current2 + (i + 1) * 3 - 1) % 10 + 1;
            score2 += current2;
            i += 3;
            if (score2 >= 1000) return score1 * (i - 1);
        }
    }

    private class Tests
    {
        [Test]
        public void TestData()
        {
            var sut = new Day2Part1();
            Assert.AreEqual(739785, sut.Run(4, 8));
        }
        
        [Test]
        public void Data()
        {
            var sut = new Day2Part1();
            Assert.AreEqual(-1, sut.Run(6, 8));
        }
    }
}
