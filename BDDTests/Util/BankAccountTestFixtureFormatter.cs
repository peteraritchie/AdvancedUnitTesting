using System.IO;
using Tests.BDD.BaseFixture;

namespace Tests.Util
{
	public class BankAccountTestFixtureFormatter : IFixtureFormatter
	{
		public void FormatGiven(object instance, TextWriter writer)
		{
			var asBase = instance as BankAccountTestFixtureBase;
			if (asBase == null)
			{
#if DEBUG
				writer.WriteLine("{0} is not of type {1}", instance.GetType().FullName, typeof(BankAccountTestFixtureBase));
#endif
				return;
			}
			writer.WriteLine("Given:<dd>bank account of type {0} with balance of {1}</dd><br/>", 
				asBase.BankAccount.AccountType, asBase.BankAccount.Balance);
		}
	}
}