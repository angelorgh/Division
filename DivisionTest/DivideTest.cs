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
            double actual = Division.Divide(num1,num2);
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Division_10_divided_by_5_Passes()
        {
            double num1 = 10;
            double num2 = 5;
            double expected = 2;
            double actual = Division.Divide(num1,num2);
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Division_66_divided_by_23_Passes()
        {
            double num1 = 66;
            double num2 = 23;
            double expected = 2.869565217391304;
            double actual = Division.Divide(num1,num2);
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Division_Negative10_divided_by_3_Passes()
        {
            double num1 = -10;
            double num2 = 3;
            double expected = -3.3333333333333335;
            double actual = Division.Divide(num1,num2);
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Division_40_divided_by_0_Fails()
        {
            double num1 = 40;
            double num2 = 0;
            Assert.Throws<System.DivideByZeroException>(() => Division.Divide(num1,num2));
        }

        [Test]
        public void Division_Minus55_divided_by_0_Fails()
        {
            double num1 = -55;
            double num2 = 0;
            Assert.Throws<System.DivideByZeroException>(() => Division.Divide(num1,num2));
        }

        [Test]
        public void Division_1887_divided_by_0_Fails()
        {
            double num1 = 1887;
            double num2 = 0;
            Assert.Throws<System.DivideByZeroException>(() => Division.Divide(num1,num2));
        }

        [Test]
        public void Division_Minus309809Point92037_divided_by_0_Fails()
        {
            double num1 = 309809.92037;
            double num2 = 0;
            Assert.Throws<System.DivideByZeroException>(() => Division.Divide(num1,num2));
        }


    }
}