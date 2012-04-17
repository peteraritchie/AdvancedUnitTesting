#if true
using System;
using System.Linq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.AAA
{
	[TestClass]
	public class BankAccountTests
	{
		[TestMethod]
		public void TellerDepositCanadianCashToActiveAccountSucceeds()
		{
			BankAccount account = 
				new BankAccount(1, AccountType.Savings, 500m);

			account.Deposit(new Currency("CAD", 20.0m));
		}

		[TestMethod]
		public void TellerDepositCanadianCashToActiveAccountResultsInCorrectTransaction()
		{
			BankAccount account = new BankAccount(1, AccountType.Savings, 500m);

			account.Deposit(new Currency("CAD", 20.0m));

			DateTime datetime = account.Transactions.Last().DateTime;

			Assert.IsTrue(TranactionEqualityComparer.Instance.Equals(account.Transactions.Last(), new Transaction(datetime, 20m, false)));
		}

		[TestMethod]
		public void TellerDepositCanadianCashToFrozenAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerDepositCanadianCashToInactiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerDepositCanadianChequeToActiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerDepositCanadianChequeToFrozenAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerDepositCanadianChequeToInactiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerDepositUnitedStatesCashToActiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerDepositUnitedStatesCashToFrozenAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerDepositUnitedStatesCashToInactiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerDepositUnitedStatesChequeToActiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerDepositUnitedStatesChequeToFrozenAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerDepositUnitedStatesChequeToInactiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerCanadianCashToActiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerCanadianCashToFrozenAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerCanadianCashToInactiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerCanadianChequeToActiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerCanadianChequeToFrozenAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerCanadianChequeToInactiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerUnitedStatesCashToActiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerUnitedStatesCashToFrozenAccountSucceeds()
		{
			// TODO:
		}
	
		[TestMethod]
		public void TellerUnitedStatesCashToInactiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerUnitedStatesChequeToActiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerUnitedStatesChequeToFrozenAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerUnitedStatesChequeToInactiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerWithdrawlActiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerWithdrawlAccountOverdrawWithinLimitSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerWithdrawlAccountOverdrawPastLimitSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerWidthdrawlFrozenAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerWidthdrawlInactiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerWithdrawlActiveAccountWithinChequeHoldSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void TellerWithdrawlActiveAccountBeyondChequeHoldSucceeds()
		{
			// TODO:
		}
		[TestMethod]
		public void AtmCanadianCashToActiveAccountSucceeds()
		{
			// TODO:
		}
		[TestMethod]
		public void AtmCanadianCashToFrozenAccountSucceeds()
		{
			// TODO:
		}
		[TestMethod]
		public void AtmCanadianCashToInactiveAccountSucceeds()
		{
			// TODO:
		}
		[TestMethod]
		public void AtmCanadianChequeToActiveAccountSucceeds()
		{
			// TODO:
		}
		[TestMethod]
		public void AtmCanadianChequeToFrozenAccountSucceeds()
		{
			// TODO:
		}
		[TestMethod]
		public void AtmCanadianChequeToInactiveAccountSucceeds()
		{
			// TODO:
		}
		[TestMethod]
		public void AtmUnitedStatesCashToActiveAccountSucceeds()
		{
			// TODO:
		}
		[TestMethod]
		public void AtmUnitedStatesCashToFrozenAccountSucceeds()
		{
			// TODO:
		}
		[TestMethod]
		public void AtmUnitedStatesCashToInactiveAccountSucceeds()
		{
			// TODO:
		}
		[TestMethod]
		public void AtmUnitedStatesChequeToActiveAccountSucceeds()
		{
			// TODO:
		}
		[TestMethod]
		public void AtmUnitedStatesChequeToFrozenAccountSucceeds()
		{
			// TODO:
		}
		[TestMethod]
		public void AtmUnitedStatesChequeToInactiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void AtmWithdrawlActiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void AtmWithdrawlAccountOverdrawWithinLimitSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void AtmWithdrawlAccountOverdrawPastLimitSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void AtmWidthdrawlFrozenAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void AtmWidthdrawlInactiveAccountSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void AtmWithdrawlActiveAccountWithinChequeHoldSucceeds()
		{
			// TODO:
		}

		[TestMethod]
		public void AtmWithdrawlActiveAccountBeyondChequeHoldSucceeds()
		{
			// TODO:
		}
	}
}
#endif