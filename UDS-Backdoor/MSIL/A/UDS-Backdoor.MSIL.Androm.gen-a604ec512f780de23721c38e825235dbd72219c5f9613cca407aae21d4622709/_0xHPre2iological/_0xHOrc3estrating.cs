using System.Diagnostics;
using System.Reflection;
using Microsoft.VisualStudio.Telemetry;

namespace _0xHPre2iological;

public static class _0xHOrc3estrating
{
	private static string _0xHSl3ganeering = string.Empty;

	public static void _0xH6niformness(TelemetryEvent _0xHG0l0sh)
	{
		_0xHG0l0sh.get_Properties()["VS.AzureTools.Version"] = _0xH4etype();
		TelemetryService.get_DefaultSession().PostEvent(_0xHG0l0sh);
	}

	private static string _0xH4etype()
	{
		if (string.IsNullOrEmpty(_0xHSl3ganeering))
		{
			_0xHSl3ganeering = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
		}
		return _0xHSl3ganeering;
	}
}
