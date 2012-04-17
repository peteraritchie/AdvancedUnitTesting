using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DocumentationGenerator.Extensions
{
	public static class CustomAttributeProvider
	{
		public static bool ContainsAnyAttributes(this ICustomAttributeProvider attributeProvider, IEnumerable<string> attributeNames)
		{
			return attributeProvider.GetCustomAttributes(true).Any(i => attributeNames.Any(y => i.GetType().Name == y));
		}
		public static bool ContainsAttribute(this ICustomAttributeProvider attributeProvider, string attributeName)
		{
			return attributeProvider.GetCustomAttributes(true).Any(i => attributeName == i.GetType().Name);
		}
	}

	public static class MethodInfo_
	{
		public static object Invoke<T>(this MethodInfo that, T instance)
		{
			return that.Invoke(instance, new object[] {});
		}
	}
}