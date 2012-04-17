#if true
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestSum()
		{
			var sut = new Summarizer();
			int actualSum = sut.CalculateSum(12, 30);
			Assert.AreEqual(42, actualSum);

			actualSum = sut.CalculateSum(52, -10);
			Assert.AreEqual(42, actualSum);

			actualSum = sut.CalculateSum(42, 0);
			Assert.AreEqual(42, actualSum);
		}
	}
}
#endif
