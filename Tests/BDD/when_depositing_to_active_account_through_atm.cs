#if true
using System;
using System.Linq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.BDD
{
	[TestClass]
	public class when_depositing_to_active_account_through_atm
	{
		[TestMethod]
		public void then_canadian_cash_succeeds()
		{
			BankAccount account = new BankAccount(1, AccountType.Savings, 500m);
			account.Deposit(new Currency("CAD", 20.0m));
		}

		[TestMethod]
		public void then_canadian_cash_results_in_correct_transaction()
		{
			BankAccount account = new BankAccount(1, AccountType.Savings, 500m);
			account.Deposit(new Currency("CAD", 20.0m));

			DateTime datetime = account.Transactions.Last().DateTime;

			Assert.IsTrue(TranactionEqualityComparer.Instance.Equals(account.Transactions.Last(), new Transaction(datetime, 20m, false)));
		}

		[TestMethod]
		public void then_canadian_cash_to_active_account_succeeds()
		{
			// TODO:
		}
		[TestMethod]
		public void then_canadian_cash_to_frozen_account_succeeds()
		{
			// TODO:
		}
		[TestMethod]
		public void then_canadian_cash_to_inactive_account_succeeds()
		{
			// TODO:
		}
		[TestMethod]
		public void then_canadian_cheque_to_active_account_succeeds()
		{
			// TODO:
		}
		[TestMethod]
		public void then_canadian_cheque_to_frozen_account_succeeds()
		{
			// TODO:
		}
		[TestMethod]
		public void then_canadian_cheque_to_inactive_account_succeeds()
		{
			// TODO:
		}
		[TestMethod]
		public void then_united_states_cash_to_active_account_succeeds()
		{
			// TODO:
		}
		[TestMethod]
		public void then_united_states_cash_to_frozen_account_succeeds()
		{
			// TODO:
		}
		[TestMethod]
		public void then_united_states_cash_to_inactive_account_succeeds()
		{
			// TODO:
		}
		[TestMethod]
		public void then_united_states_cheque_to_active_account_succeeds()
		{
			// TODO:
		}
		[TestMethod]
		public void then_united_states_cheque_to_frozen_account_succeeds()
		{
			// TODO:
		}
		[TestMethod]
		public void then_united_states_cheque_to_inactive_account_succeeds()
		{
			// TODO:
		}

		[TestMethod]
		public void then_withdrawl_active_account_succeeds()
		{
			// TODO:
		}

		[TestMethod]
		public void then_withdrawl_account_overdraw_within_limit_succeeds()
		{
			// TODO:
		}

		[TestMethod]
		public void then_withdrawl_account_overdraw_past_limit_succeeds()
		{
			// TODO:
		}

		[TestMethod]
		public void then_widthdrawl_frozen_account_succeeds()
		{
			// TODO:
		}

		[TestMethod]
		public void then_widthdrawl_inactive_account_succeeds()
		{
			// TODO:
		}

		[TestMethod]
		public void then_withdrawl_active_account_within_cheque_hold_succeeds()
		{
			// TODO:
		}

		[TestMethod]
		public void then_withdrawl_active_account_beyond_cheque_hold_succeeds()
		{
			// TODO:
		}
	}
}
#endif