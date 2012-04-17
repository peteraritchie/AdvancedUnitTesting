using System;
using Domain;

namespace Tests.Util
{
	public class BankAccountBuilder
	{
		private int id;
		private AccountType type;
		private decimal balance;

		public BankAccountBuilder WithId(int id)
		{
			this.id = id;
			return this;
		}

		public BankAccountBuilder OfType(AccountType type)
		{
			this.type = type;
			return this;
		}

		public BankAccountBuilder WithBalance(decimal balance)
		{
			this.balance = balance;
			return this;
		}

		public static implicit operator BankAccount(BankAccountBuilder builder)
		{
			if (builder == null) 
				throw new ArgumentNullException("builder");
			return new BankAccount(builder.id,
				builder.type,
				builder.balance);
		}
	}
}