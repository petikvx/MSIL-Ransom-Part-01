using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartAssembly.SmartExceptionsCore;

public sealed class Win32
{
	private struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;

		public RECT(Rectangle rectangle)
		{
			Left = rectangle.Left;
			Top = rectangle.Top;
			Bottom = rectangle.Bottom;
			Right = rectangle.Right;
		}
	}

	private struct OSVERSIONINFO
	{
		public int dwOSVersionInfoSize;

		public uint dwMajorVersion;

		public uint dwMinorVersion;

		public uint dwBuildNumber;

		public uint dwPlatformId;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string szCSDVersion;

		public ushort wServicePackMajor;

		public ushort wServicePackMinor;

		public ushort wSuiteMask;

		public byte wProductType;

		private byte wReserved;
	}

	public struct SYSTEM_INFO
	{
		public ushort wProcessorArchitecture;

		private ushort wReserved;

		public uint dwPageSize;

		public IntPtr lpMinimumApplicationAddress;

		public IntPtr lpMaximumApplicationAddress;

		public IntPtr dwActiveProcessorMask;

		public uint dwNumberOfProcessors;

		public uint dwProcessorType;

		public uint dwAllocationGranularity;

		public ushort wProcessorLevel;

		public ushort wProcessorRevision;
	}

	private const int DT_WORDBREAK = 16;

	private const int DT_CALCRECT = 1024;

	private const int DT_NOPREFIX = 2048;

	private const int VER_NT_WORKSTATION = 1;

	private const int SM_SERVERR2 = 89;

	private const int PROCESSOR_ARCHITECTURE_AMD64 = 9;

	private static bool s_ReadVersionInfo;

	private static OSVERSIONINFO s_VersionInfo;

	private static OSVERSIONINFO VersionInfo
	{
		get
		{
			if (!s_ReadVersionInfo)
			{
				s_VersionInfo = default(OSVERSIONINFO);
				try
				{
					s_VersionInfo.dwOSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFO));
					GetVersionEx(ref s_VersionInfo);
					s_ReadVersionInfo = true;
				}
				catch
				{
				}
			}
			return s_VersionInfo;
		}
	}

	internal static bool IsX64
	{
		get
		{
			try
			{
				SYSTEM_INFO lpSystemInfo = default(SYSTEM_INFO);
				GetSystemInfo(ref lpSystemInfo);
				return lpSystemInfo.wProcessorArchitecture == 9;
			}
			catch
			{
				return false;
			}
		}
	}

	internal static bool IsServerR2
	{
		get
		{
			try
			{
				return GetSystemMetrics(89) != 0;
			}
			catch
			{
				return false;
			}
		}
	}

	internal static bool IsWorkstation => VersionInfo.wProductType == 1;

	internal static string ServicePack => VersionInfo.szCSDVersion;

	[DllImport("shell32")]
	private static extern int ExtractIconEx(string lpszFile, int nIconIndex, ref int phiconLarge, ref int phiconSmall, int nIcons);

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int DrawText(IntPtr hDC, string text, int textLength, ref RECT lpRect, int format);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr hDC, IntPtr hGdiObj);

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref OSVERSIONINFO o);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int smIndex);

	[DllImport("kernel32.dll")]
	private static extern void GetSystemInfo(ref SYSTEM_INFO lpSystemInfo);

	public static Icon GetApplicationIcon()
	{
		try
		{
			return GetApplicationIconInternal();
		}
		catch (Exception)
		{
			return Resources.GetIcon("default");
		}
	}

	private static Icon GetApplicationIconInternal()
	{
		int phiconLarge = 0;
		int phiconLarge2 = 0;
		int num = ExtractIconEx(Application.get_ExecutablePath(), -1, ref phiconLarge2, ref phiconLarge2, 1);
		if (num > 0)
		{
			ExtractIconEx(Application.get_ExecutablePath(), 0, ref phiconLarge, ref phiconLarge2, 1);
			if (phiconLarge != 0)
			{
				return Icon.FromHandle(new IntPtr(phiconLarge));
			}
		}
		return null;
	}

	internal static int GetTextHeight(Graphics graphics, string text, Font font, int width)
	{
		try
		{
			return GetTextHeightGDIInternal(graphics, text, font, width);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)GetTextHeightGDIPlusInternal(graphics, text, font, width) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	private static int GetTextHeightGDIPlusInternal(Graphics graphics, string text, Font font, int width)
	{
		return Size.Ceiling(graphics.MeasureString(text, font, width)).Height;
	}

	private static int GetTextHeightGDIInternal(Graphics graphics, string text, Font font, int width)
	{
		RECT lpRect = new RECT(new Rectangle(0, 0, width, 10000));
		IntPtr hdc = graphics.GetHdc();
		IntPtr hGdiObj = font.ToHfont();
		IntPtr hGdiObj2 = SelectObject(hdc, hGdiObj);
		DrawText(hdc, text, -1, ref lpRect, 3088);
		SelectObject(hdc, hGdiObj2);
		graphics.ReleaseHdc(hdc);
		return lpRect.Bottom - lpRect.Top;
	}
}
