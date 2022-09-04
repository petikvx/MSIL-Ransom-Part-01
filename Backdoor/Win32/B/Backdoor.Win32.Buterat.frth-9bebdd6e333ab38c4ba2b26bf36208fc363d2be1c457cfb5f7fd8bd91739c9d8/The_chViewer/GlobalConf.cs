using System.Net;

namespace The_chViewer;

public static class GlobalConf
{
	public static string BrowserName { get; set; }

	public static string BrowserVersion { get; set; }

	public static string UserAgent { get; set; }

	public static bool UseBg20 { get; set; }

	static GlobalConf()
	{
		BrowserName = "lib2ch";
		BrowserVersion = "0.00";
		UserAgent = $"Monazilla/1.00 ({BrowserName}/{BrowserVersion})";
		UseBg20 = false;
		WebRequest.DefaultWebProxy = null;
	}
}
