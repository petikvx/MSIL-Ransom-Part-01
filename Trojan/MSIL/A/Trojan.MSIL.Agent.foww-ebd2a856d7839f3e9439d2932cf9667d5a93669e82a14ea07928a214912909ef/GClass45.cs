using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public static class GClass45
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class28
	{
		public static readonly Class28 class28_0 = new Class28();

		public static GClass8.GDelegate2 gdelegate2_0;

		internal bool method_0(IntPtr hWnd, IntPtr lParam)
		{
			if (GClass8.IsWindowVisible(hWnd))
			{
				GClass8.PostMessage(hWnd, 16, 0, 0);
			}
			return true;
		}
	}

	private const uint uint_0 = 2u;

	private const uint uint_1 = 4u;

	private const uint uint_2 = 8u;

	private const uint uint_3 = 16u;

	private const uint uint_4 = 2048u;

	private const uint uint_5 = 0u;

	private const uint uint_6 = 2u;

	private const int int_0 = 114;

	private const uint uint_7 = 128u;

	private const uint uint_8 = 1u;

	private const int int_1 = 16;

	private const uint uint_9 = 17u;

	private const uint uint_10 = 2u;

	public static uint smethod_0()
	{
		GClass8.GStruct0 plii = default(GClass8.GStruct0);
		plii.uint_0 = (uint)Marshal.SizeOf((object)plii);
		plii.uint_1 = 0u;
		if (!GClass8.GetLastInputInfo(ref plii))
		{
			return 0u;
		}
		return plii.uint_1;
	}

	public static void smethod_1(Point p, bool isMouseDown)
	{
		GClass8.mouse_event(isMouseDown ? 2u : 4u, p.X, p.Y, 0, 0);
	}

	public static void smethod_2(Point p, bool isMouseDown)
	{
		GClass8.mouse_event(isMouseDown ? 8u : 16u, p.X, p.Y, 0, 0);
	}

	public static void smethod_3(Point p)
	{
		GClass8.SetCursorPos(p.X, p.Y);
	}

	public static void smethod_4(Point p, bool scrollDown)
	{
		GClass8.mouse_event(2048u, p.X, p.Y, scrollDown ? (-120) : 120, 0);
	}

	public static void smethod_5(byte key, bool keyDown)
	{
		GClass8.keybd_event(key, 0, (!keyDown) ? 2u : 0u, 0);
	}

	public static bool smethod_6()
	{
		IntPtr lpvParam = IntPtr.Zero;
		GClass8.SystemParametersInfo(114u, 0u, ref lpvParam, 0u);
		return lpvParam != IntPtr.Zero;
	}

	public static void smethod_7()
	{
		IntPtr intPtr = GClass8.OpenDesktop("Screen-saver", 0, inherit: false, 129u);
		if (intPtr != IntPtr.Zero)
		{
			GClass8.EnumDesktopWindows(intPtr, delegate(IntPtr hWnd, IntPtr lParam)
			{
				if (GClass8.IsWindowVisible(hWnd))
				{
					GClass8.PostMessage(hWnd, 16, 0, 0);
				}
				return true;
			}, IntPtr.Zero);
			GClass8.CloseDesktop(intPtr);
		}
		else
		{
			GClass8.PostMessage(GClass8.GetForegroundWindow(), 16, 0, 0);
		}
		IntPtr lpvParam = IntPtr.Zero;
		GClass8.SystemParametersInfo(17u, 1u, ref lpvParam, 2u);
	}
}