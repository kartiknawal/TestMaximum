using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximumProgram;

namespace MaximumNumbersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_MaxNumberAtFirstPosition_Return_SameNumber()
        {
            MaximumNumber maximumValue = new MaximumNumber();
            int maximumInteger = maximumValue.GetMaximumInteger(20, 8, 14);
            Assert.AreEqual(20, maximumInteger);
        }
        [TestMethod]
        public void Given_MaxNumberAtSecondPosition_Return_SameNumber()
        {
            MaximumNumber maximumValue = new MaximumNumber();
            int maximumInteger = maximumValue.GetMaximumInteger(59, 88, 21);
            Assert.AreEqual(88, maximumInteger);
        }
        [TestMethod]
        public void Given_MaxNumberAtThirdPosition_Return_SameNumber()
        {
            MaximumNumber maximumValue = new MaximumNumber();
            int maximumInteger = maximumValue.GetMaximumInteger(8, 52, 79);
            Assert.AreEqual(79, maximumInteger);
        }

        [TestMethod]
        public void Given_MaxFloatAtFirstPosition_Return_SameFloat()
        {
            MaximumNumber maximumValue = new MaximumNumber();
            double maximumDouble = maximumValue.GetMaximumFloat(18.88, 9.0, 15.87);
            Assert.AreEqual(18.88, maximumDouble);
        }
        [TestMethod]
        public void Given_MaxFloatAtSecondPosition_Return_SameFloat()
        {
            MaximumNumber maximumValue = new MaximumNumber();
            double maximumDouble = maximumValue.GetMaximumFloat(18.88, 99.0, 15.87);
            Assert.AreEqual(99.0, maximumDouble);
        }

        [TestMethod]
        public void Given_MaxFloatAtThirdPosition_Return_SameFloat()
        {
            MaximumNumber maximumValue = new MaximumNumber();
            double maximumDouble = maximumValue.GetMaximumFloat(18.88, 9.0, 86.87);
            Assert.AreEqual(86.87, maximumDouble);
        }
    }
}
