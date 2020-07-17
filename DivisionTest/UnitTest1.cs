using NUnit.Framework;
using DivisionServices;

namespace DivisionTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Division_4_divided_by_2_Passes()
        {
            double num1 = 4;
            double num2 = 2;
            double expected = 2;
            Assert.AreEqual(expected, Division.Divide(num1,num2));
        }
    }
}