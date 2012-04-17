using System;
using System.Collections.Generic;

namespace Domain
{
	public class ShoppingCart
	{
		readonly List<CartItem> items = new List<CartItem>();

		public ShoppingCart()
			:this(Guid.NewGuid())
		{
		}

		public ShoppingCart(Guid guid)
		{
			Id = guid;
		}

		public Guid Id { get; private set; }

		private void CorruptData()
		{
			Id = Guid.Empty;
		}
		public void Add(CartItem cartItem)
		{
			items.Add(cartItem);	
		}

		public void CheckOut(int customerId, string creditCardNumber, int creditCardType, string ccv)
		{
			// TODO: implement this correctly
			PurchaseHistoryRepository.Instance.Add(new Purchase(customerId));
		}
	}
}