using System;
using System.Runtime.InteropServices;

namespace WebCruiserWVS;

public class WCRSetting
{
	public struct Struct_INTERNET_PROXY_INFO
	{
		public int dwAccessType;

		public IntPtr proxy;

		public IntPtr proxyBypass;
	}

	public static bool UseProxy;

	public static string ProxyAddress;

	public static int ProxyPort;

	public static string ProxyUsername;

	public static string ProxyPassword;

	public static bool chkReplace1;

	public static string FiltExpr1;

	public static string RepExpr1;

	public static bool chkReplace2;

	public static string FiltExpr2;

	public static string RepExpr2;

	public static bool chkReplace3;

	public static string FiltExpr3;

	public static string RepExpr3;

	public static string Edition;

	public static string UserAgent;

	public static int MaxHTTPThreadNum;

	public static int SecondsDelay;

	public static int ScanDepth;

	public static string CrawlableExt;

	public static int MultiSitesNum;

	public static bool bool_0;

	public static bool bool_1;

	public static bool bool_2;

	public static bool bool_3;

	public static bool bool_4;

	public static bool bool_5;

	public static string string_0;

	public static string string_1;

	public static bool bool_6 = true;

	[DllImport("wininet.dll", SetLastError = true)]
	private static extern bool InternetSetOption(IntPtr intptr_0, int int_0, IntPtr intptr_1, int int_1);

	public static void RefreshIESettings(string strProxy)
	{
		Struct_INTERNET_PROXY_INFO struct_INTERNET_PROXY_INFO = default(Struct_INTERNET_PROXY_INFO);
		if (string.IsNullOrEmpty(strProxy))
		{
			struct_INTERNET_PROXY_INFO.dwAccessType = 1;
		}
		else
		{
			struct_INTERNET_PROXY_INFO.dwAccessType = 3;
		}
		struct_INTERNET_PROXY_INFO.proxy = Marshal.StringToHGlobalAnsi(strProxy);
		struct_INTERNET_PROXY_INFO.proxyBypass = Marshal.StringToHGlobalAnsi("local");
		IntPtr intPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf((object)struct_INTERNET_PROXY_INFO));
		Marshal.StructureToPtr((object)struct_INTERNET_PROXY_INFO, intPtr, fDeleteOld: true);
		InternetSetOption(IntPtr.Zero, 38, intPtr, Marshal.SizeOf((object)struct_INTERNET_PROXY_INFO));
	}
}
