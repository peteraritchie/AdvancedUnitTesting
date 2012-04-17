namespace Domain
{
	public class Currency
	{
		public Currency(string currencyType, decimal currencyAmount)
		{
			Amount = currencyAmount;
		}

		public decimal Amount { get; private set; }
	}
}