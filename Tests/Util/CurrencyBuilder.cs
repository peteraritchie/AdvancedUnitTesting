using Domain;

namespace Tests.Util
{
	public class CurrencyBuilder
	{
		private decimal amount;
		private string currencyType;
		public CurrencyBuilder AsCanadian()
		{
			currencyType = "CAD";
			return this;
		}
		public CurrencyBuilder AsAmerican()
		{
			currencyType = "USD";
			return this;
		}

		public CurrencyBuilder WithAmount(decimal amount)
		{
			this.amount = amount;
			return this;
		}

		public static implicit operator Currency(CurrencyBuilder builder)
		{
			return new Currency(builder.currencyType, builder.amount);
		}
	}
}