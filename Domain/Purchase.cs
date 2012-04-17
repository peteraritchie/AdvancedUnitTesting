namespace Domain
{
	public class Purchase
	{
		public int CustomerId { get; private set; }

		public Purchase(int customerId)
		{
			CustomerId = customerId;
		}
	}
}