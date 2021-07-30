using System;
using NUnit.Framework;
using CalculatorMutant;

namespace TestUnit
{ 

    [TestFixture]
    public class UnitTest1
    {

        [TestCase(2, 4, 6)]
        [TestCase(8, 6, 14)]
        [TestCase(8, 8, 16)]
        public void Addition_TC(double a, double b, double c)

        {
            Assert.AreEqual(c, CalcMut.Addition(a, b));

        }


        [TestCase(-10, 20, -30)]
        [TestCase(40, -50, 90)]
        [TestCase(-100, -200, 100)]
        public void Subtraction_TC(double a, double b, double c)
        {
            Assert.AreEqual(c, CalcMut.Subtraction(a, b));
        }

        [TestCase(2, 2, 4)]
        [TestCase(5, 5, 25)]
        [TestCase(10, 20, 200)]
        public void Multiplication_TC(double a, double b, double c)
        {

            Assert.AreEqual(c, CalcMut.Multiplication(a, b));
        }

        [TestCase(50, 5, 10)]
        [TestCase(-100, -10, 10)]
        [TestCase(-15, 5, -3)]
       // [TestCase(1, 3, 1 / 3)]
       // [TestCase(2, 1, 2)]
       // [TestCase(9, 3, 3)]
        public void Division_TC(double a, double b, double c)
        {
            Assert.AreEqual(c, CalcMut.Division(a, b));
        }


    }
}