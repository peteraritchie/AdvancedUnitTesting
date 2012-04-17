#if true
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class UnitTest3
	{
		private Summarizer sut;

		[TestInitialize]
		public void SetUp()
		{
			sut = new Summarizer();
		}

		[TestCleanup]
		public void TearDown()
		{
			sut = null;
		}

		[TestMethod]
		public void TestPositiveSummation()
		{
			int actualSum = sut.CalculateSum(12, 30);
			Assert.AreEqual(42, actualSum);
		}

		[TestMethod]
		public void TestPositiveNegativeSummation()
		{
			int actualSum = sut.CalculateSum(52, -10);
			Assert.AreEqual(42, actualSum);
		}

		[TestMethod]
		public void TestPositiveZeroSummation()
		{
			int actualSum = sut.CalculateSum(42, 0);
			Assert.AreEqual(42, actualSum);
		}
	}
}
#endif