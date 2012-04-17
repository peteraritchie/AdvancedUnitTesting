using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using DocumentationGenerator.Extensions;
using Tests.BDD.BaseFixture;
using Tests.Util;

namespace DocumentationGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			TextWriter writer = args.Length > 1 ? new StreamWriter(args[args.Length - 1]) : Console.Out ;

			writer.WriteLine(String.Format("<html>{0}Date:&nbsp;{1:D}<br/>", Environment.NewLine, DateTime.Now));
			foreach(var arg in args.Take(args.Length - 1))
			{
				BuildAssemblyDocumentation(arg, writer);
			}
			writer.WriteLine("</html>");
			if(writer != Console.Out) writer.Dispose();
		}

		private static void BuildAssemblyDocumentation(String assemblyName, TextWriter writer)
		{
			writer.WriteLine("<p>");
			foreach (var fixture in GetTestFixtures(assemblyName))
			{
				writer.WriteLine("<p style=\"page-break-before: always\">");
				writer.WriteLine("<b>Scenario: {0}</b><br/>", fixture.Name.Replace('_', ' '));
				writer.WriteLine("<br/>");
				var instance = GetInstanceOf(fixture);
				var formatter = GetFormatterFor(fixture);
				RunFixtureSetup(instance);
				if (formatter != null) formatter.FormatGiven(instance, writer);
				if (instance != null)
				{
					WriteFixtureAssertions(instance, writer);
				}
				writer.WriteLine();
			}
		}

		private static IFixtureFormatter GetFormatterFor(Type fixture)
		{
			if (fixture.BaseType.FullName == typeof (BankAccountTestFixtureBase).FullName)
				return new BankAccountTestFixtureFormatter();
			return null;
		}

		private static void WriteFixtureAssertions(object fixture, TextWriter writer)
		{
			writer.WriteLine("Assertions:<br/>");
			try
			{
				foreach (var method in fixture.GetType().GetMethods()
					.Where(m => m.ContainsAnyAttributes(new[] { "TestMethodAttribute", "TestAttribute" })))
				{
					writer.WriteLine("<dd>{0}:&nbsp;{1}</dd>", (RunTest(fixture, method) ? "<font color=\"green\">PASS</font>" : "<font color=\"red\">FAIL</font>"), method.Name.Replace('_', ' '));
				}
			}
			catch (Exception ex)
			{
				writer.WriteLine("Setup threw an exception: " + ex.Message + "<br/>");
			}
		}

		private static bool RunTest(object fixture, MethodInfo method)
		{
			try
			{
				method.Invoke(fixture, new object[] {});
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}

		private static void RunFixtureSetup(object fixture)
		{
			foreach (var m in fixture.GetType().GetMethods().Where(method => method.ContainsAnyAttributes(new[]{"TestInitializeAttribute", "SetUpAttribute"})))
			{
				m.Invoke(fixture);
			}
		}

		private static object GetInstanceOf(Type testFixture)
		{
			return Activator.CreateInstance(testFixture);
		}

		private static IEnumerable<Type> GetTestFixtures(String assemblyName)
		{
			return Assembly.LoadFrom(assemblyName).GetTypes()
				.Where(t => !t.IsAbstract 
					&& t.ContainsAnyAttributes(new[] { "TestClassAttribute", "TestFixtureAttribute" }) && !t.ContainsAttribute("IgnoreAttribute"));
		}
	}
}
