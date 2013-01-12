#if true
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Util;

namespace Tests.Fluent
{
	[TestClass]
	public class when_depositing_to_active_account_via_wire_transfer
	{
		[TestMethod]
		public void Test()
		{
			BankAccount bankAccount = 
				new BankAccountBuilder()
				.OfType(AccountType.Savings)
				.WithBalance(500m)
				.WithId(1);

			bankAccount.Deposit(new CurrencyBuilder()
				.AsCanadian()
				.WithAmount(100));

			Assert.AreEqual(bankAccount.Balance, 600m);
		}
	}
}
#endif