using System;
using System.Collections.Generic;

namespace Domain
{
	public class TranactionEqualityComparer : IEqualityComparer<Transaction>
	{
		private static readonly Lazy<TranactionEqualityComparer> lazy = new Lazy<TranactionEqualityComparer>(() => new TranactionEqualityComparer());
		public static TranactionEqualityComparer Instance { get { return lazy.Value; } }

		public bool Equals(Transaction x, Transaction y)
		{
			if (ReferenceEquals(null, y)) return false;
			if (ReferenceEquals(x, y)) return true;
			return y.DateTime.Equals(x.DateTime) && y.Amount == x.Amount && y.WasDebit.Equals(x.WasDebit);
		}

		public int GetHashCode(Transaction obj)
		{
			unchecked
			{
				int result = obj.DateTime.GetHashCode();
				result = (result * 397) ^ obj.Amount.GetHashCode();
				result = (result * 397) ^ obj.WasDebit.GetHashCode();
				return result;
			}
		}
	}
}