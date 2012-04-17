#if true
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Util
{
	/// <summary>
	/// ClassInitialize
	///  TestInitialize
	///   TestMethod1
	///  TestCleanup
	///  TestInitialize
	///   TestMethod2
	///  TestCleanup
	/// ClassCleanup
	/// </summary>
	[TestClass, Ignore]
	public class Template
	{
		[ClassInitialize]
		public static void ClassInitialize(TestContext testContext)
		{
			Debug.WriteLine("ClassInitialize");
		}

		[ClassCleanup]
		public static void ClassCleanup()
		{
			Debug.WriteLine("ClassCleanup");
		}

		[TestMethod]
		public void TestMethod1()
		{
			Debug.WriteLine("TestMethod1");
		}

		[TestMethod]
		public void TestMethod2()
		{
			Debug.WriteLine("TestMethod2");
		}

		[TestInitialize]
		public void TestInitialize()
		{
			Debug.WriteLine("TestInitialize");
		}

		[TestCleanup]
		public void TestCleanup()
		{
			Debug.WriteLine("TestCleanup");
		}
	}
}
#endif
