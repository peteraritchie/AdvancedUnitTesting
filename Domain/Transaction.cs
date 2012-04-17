using System;

namespace Domain
{
	public class Transaction
	{
		public Transaction(DateTime dateTime, decimal amount, bool wasDebit)
		{
			DateTime = dateTime;
			Amount = amount;
			WasDebit = wasDebit;
		}

		public DateTime DateTime { get; private set; }
		public decimal Amount { get; private set; }
		public bool WasDebit { get; private set; }

	}
}