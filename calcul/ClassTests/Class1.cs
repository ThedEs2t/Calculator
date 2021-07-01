using System;


using NUnit.Framework;


namespace ClassTests
{
    public class Plus
    {
        [TestCase(3, 5, 8)]
        [TestCase(2, 8, 10)]
        [TestCase(2, 1, 3)]
        public void calculatetest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Plus();
            var actualResult = calculator.calculate(firstValue, secondValue);
        }

    }
}
