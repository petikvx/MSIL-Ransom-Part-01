using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartAssembly.SmartExceptionsCore;

public class Win32
{
	private struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;

		public RECT(Rectangle rectangle_0)
		{
			Left = rectangle_0.Left;
			Top = rectangle_0.Top;
			Bottom = rectangle_0.Bottom;
			Right = rectangle_0.Right;
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
				SYSTEM_INFO system_INFO_ = default(SYSTEM_INFO);
				GetSystemInfo(ref system_INFO_);
				return system_INFO_.wProcessorArchitecture == 9;
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
	private static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref RECT rect_0, int int_1);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref OSVERSIONINFO osversioninfo_0);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int int_0);

	[DllImport("kernel32.dll")]
	private static extern void GetSystemInfo(ref SYSTEM_INFO system_INFO_0);

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
		int int_ = 0;
		int int_2 = 0;
		int num = ExtractIconEx(Application.get_ExecutablePath(), -1, ref int_2, ref int_2, 1);
		if (num > 0)
		{
			ExtractIconEx(Application.get_ExecutablePath(), 0, ref int_, ref int_2, 1);
			if (int_ != 0)
			{
				return Icon.FromHandle(new IntPtr(int_));
			}
		}
		return null;
	}

	internal static int GetTextHeight(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		try
		{
			return GetTextHeightGDIInternal(graphics_0, string_0, font_0, int_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)GetTextHeightGDIPlusInternal(graphics_0, string_0, font_0, int_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	private static int GetTextHeightGDIPlusInternal(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	private static int GetTextHeightGDIInternal(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		RECT rect_ = new RECT(new Rectangle(0, 0, int_0, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = font_0.ToHfont();
		IntPtr intptr_2 = SelectObject(hdc, intptr_);
		DrawText(hdc, string_0, -1, ref rect_, 3088);
		SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return rect_.Bottom - rect_.Top;
	}
}
