using System;
using System.Reflection;
using Microsoft.VisualStudio.WindowsAzure.ServiceManagement.Utilities;

namespace _0xHB2ceps;

internal static class _0xHAstonish7ents
{
	private static Lazy<string> _0xHLactalbumin8 = new Lazy<string>(delegate
	{
		Version version = Assembly.GetExecutingAssembly().GetName().Version;
		return ServiceManagementUtilities.GetUserAgentString("Visual Studio SDK for .NET", version);
	});

	public static string _0xHS1l1nchak => _0xHLactalbumin8.Value;
}
