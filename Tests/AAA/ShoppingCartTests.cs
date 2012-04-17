#if true
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.AAA
{
	[TestClass]
	public class ShoppingCartTests
	{
		[TestMethod]
		public void Checkout_ValidShoppingCart_Succeeds()
		{
			var shoppingCart = new ShoppingCart();

			shoppingCart.Add(new CartItem(2, 1));
			shoppingCart.CheckOut(3, "4242424242424242", 4, "111");

			Assert.AreNotEqual(0, PurchaseHistoryRepository.Instance.FindForCustomer(3));
		}
	}
}
#endif