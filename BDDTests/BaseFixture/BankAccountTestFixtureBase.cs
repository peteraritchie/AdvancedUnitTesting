using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.BDD.BaseFixture
{
	[TestClass]
	public abstract class BankAccountTestFixtureBase
	{
		public BankAccount BankAccount { get; set; }

		/// <summary>
		/// Set up "Given"
		/// </summary>
		[TestInitialize]
		public void SetUp()
		{
			BankAccount = new BankAccount(1, AccountType.Savings, 500m);
		}
	}
}