using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximumProgram;

namespace MaximumNumbersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenIntegerArray_Should_Return_LargestInteger()
        {
            int[] values = { 89, 8, 99, 18, 2 };
            MaximumNumber<int> maximumNumber = new MaximumNumber<int>(values);
            int max = maximumNumber.GetMaximumValue();
            Assert.AreEqual(99, max);
        }
        [TestMethod]
        public void GivenFloatArray_Should_Return_LargestFloat()
        {
            double[] values = { 0.77, 0.6, 1.3, 32.233, 3.122 };
            MaximumNumber<double> maximumNumber = new MaximumNumber<double>(values);
            double max = maximumNumber.GetMaximumValue();
            Assert.AreEqual(32.233, max);
        }
        [TestMethod]
        public void GivenStringArray_Should_Return_LargestString()
        {
            string[] values = { "lion", "cat", "dog", "elephant", "rat" };
            MaximumNumber<string> maximumNumber = new MaximumNumber<string>(values);
            string max = maximumNumber.GetMaximumValue();
            Assert.AreEqual("rat", max);
        }
    }
}
