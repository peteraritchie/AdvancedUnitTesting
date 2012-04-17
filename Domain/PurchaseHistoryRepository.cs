using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
	public class PurchaseHistoryRepository
	{
		private static readonly Lazy<PurchaseHistoryRepository> lazy = new Lazy<PurchaseHistoryRepository>(()=> new PurchaseHistoryRepository());
		public static PurchaseHistoryRepository Instance { get { return lazy.Value; } }

		private PurchaseHistoryRepository()
		{
		}

		private readonly List<Purchase> purchases = new List<Purchase>();

		public IEnumerable<Purchase> FindForCustomer(int customerId)
		{
			return from p 
				   in purchases 
				   where p.CustomerId == customerId 
				   select p;
		}

		public void Add(Purchase purchase)
		{
			purchases.Add(purchase);
		}
	}
}