#if false
using System;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class Class2Test
	{
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void InvalidTypeValueCausesCorrectException()
		{
			Class2 target = new Class2();
			target.SetIntType(3);
		}
	}
}
#endif