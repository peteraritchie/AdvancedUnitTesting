namespace Domain
{
	public class CartItem
	{
		public CartItem(int productId, int quantity)
		{
			ProductId = productId;
			Quantity = quantity;
		}

		public int Quantity { get; private set; }

		public int ProductId { get; private set; }
	}
}