using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.Build.Shared;

internal static class AssemblyResources
{
	private static readonly ResourceManager resources = new ResourceManager("MSBuild.Strings", Assembly.GetExecutingAssembly());

	internal static string GetString(string name)
	{
		return resources.GetString(name, CultureInfo.CurrentUICulture);
	}
}
