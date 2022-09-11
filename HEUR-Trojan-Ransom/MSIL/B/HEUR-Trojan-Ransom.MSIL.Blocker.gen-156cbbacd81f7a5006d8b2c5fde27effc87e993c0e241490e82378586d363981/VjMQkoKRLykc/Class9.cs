using System.Reflection;
using System.Resources;

namespace VjMQkoKRLykc;

internal static class Class9
{
	private static ResourceManager resourceManager_0 = new ResourceManager(" ", Assembly.GetExecutingAssembly());

	internal static string String_0 => smethod_0(" ");

	internal static string smethod_0(string string_0)
	{
		return resourceManager_0.GetString(string_0);
	}
}
