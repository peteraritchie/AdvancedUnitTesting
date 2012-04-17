#if true
using Domain;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	public class UnitTest4
	{
		private Summarizer sut;

		[SetUp]
		public void SetUp()
		{
			sut = new Summarizer();
		}

		[TearDown]
		public void TearDown()
		{
			sut = null;
		}

		[TestCase(12, 30, 42)]
		[TestCase(52, -10, 42)]
		[TestCase(42, 0, 42)]
		public void TestSummation(int left, int right, int total)
		{
			int actualSum = sut.CalculateSum(left, right);
			Assert.AreEqual(total, actualSum);
		}
	}
}
#endif