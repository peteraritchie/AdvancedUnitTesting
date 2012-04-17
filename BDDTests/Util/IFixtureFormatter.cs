using System.IO;

namespace Tests.Util
{
	public interface IFixtureFormatter
	{
		void FormatGiven(object instance, TextWriter writer);
	}
}