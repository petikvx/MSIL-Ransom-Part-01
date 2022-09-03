using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace JavaCPL;

public static class GClass4
{
	internal delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

	internal delegate bool EnumWindowProc(IntPtr hWnd, IntPtr parameter);

	private class GDI32
	{
		[DllImport("GDI32.dll")]
		public static extern bool BitBlt(int hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, int hdcSrc, int nXSrc, int nYSrc, int dwRop);

		[DllImport("GDI32.dll")]
		public static extern int CreateCompatibleBitmap(int hdc, int nWidth, int nHeight);

		[DllImport("GDI32.dll")]
		public static extern int CreateCompatibleDC(int hdc);

		[DllImport("GDI32.dll")]
		public static extern bool DeleteDC(int hdc);

		[DllImport("GDI32.dll")]
		public static extern bool DeleteObject(int hObject);

		[DllImport("GDI32.dll")]
		public static extern int GetDeviceCaps(int hdc, int nIndex);

		[DllImport("GDI32.dll")]
		public static extern int SelectObject(int hdc, int hgdiobj);
	}

	private class User32
	{
		[DllImport("User32.dll")]
		public static extern IntPtr GetForegroundWindow();

		[DllImport("User32.dll")]
		public static extern int GetWindowDC(int hWnd);

		[DllImport("User32.dll")]
		public static extern int ReleaseDC(int hWnd, int hDC);

		[DllImport("user32.dll")]
		public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

		[DllImport("user32.dll")]
		public static extern int GetWindow(int hWnd, GW uCmd);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumChildWindows(IntPtr hwndParent, EnumWindowsProc lpEnumFunc, IntPtr lParam);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

		[DllImport("user32.dll")]
		public static extern uint RealGetWindowClass(IntPtr hwnd, [Out] StringBuilder pszType, uint cchType);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);
	}

	public enum GW
	{
		HWNDFIRST,
		HWNDLAST,
		HWNDNEXT,
		HWNDPREV,
		OWNER,
		CHILD
	}

	public struct RECT
	{
		public int left;

		public int top;

		public int right;

		public int bottom;
	}

	public static IntPtr smethod_0()
	{
		return User32.GetForegroundWindow();
	}

	public static bool smethod_1(IntPtr intptr_0, IntPtr intptr_1)
	{
		if (!(GCHandle.FromIntPtr(intptr_1).Target is List<IntPtr> list))
		{
			throw new InvalidCastException("GCHandle Target could not be cast as List<IntPtr>");
		}
		list.Add(intptr_0);
		return true;
	}

	public static IntPtr[] smethod_2(IntPtr intptr_0)
	{
		List<IntPtr> list = new List<IntPtr>();
		GCHandle value = GCHandle.Alloc(list);
		try
		{
			EnumWindowsProc lpEnumFunc = smethod_1;
			User32.EnumChildWindows(intptr_0, lpEnumFunc, GCHandle.ToIntPtr(value));
		}
		finally
		{
			if (value.IsAllocated)
			{
				value.Free();
			}
		}
		return list.ToArray();
	}

	public static string smethod_3(IntPtr intptr_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		User32.RealGetWindowClass(intptr_0, stringBuilder, 255u);
		return stringBuilder.ToString();
	}

	public static string smethod_4(IntPtr intptr_0)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		User32.GetWindowText(intptr_0, stringBuilder, stringBuilder.Capacity);
		return stringBuilder.ToString();
	}

	public static IntPtr smethod_5()
	{
		IntPtr intptr_ = smethod_0();
		int num = 0;
		int num2 = 0;
		IntPtr intPtr = smethod_6(smethod_2(intptr_), "SunAwtCanvas");
		User32.GetWindowRect(intPtr, out var lpRect);
		num = lpRect.right - lpRect.left;
		num2 = lpRect.bottom - lpRect.top;
		if (num > 700 && num2 > 500)
		{
			return intPtr;
		}
		return IntPtr.Zero;
	}

	public static IntPtr smethod_6(IntPtr[] intptr_0, string string_0)
	{
		IntPtr zero = IntPtr.Zero;
		IntPtr intPtr = IntPtr.Zero;
		int num = 0;
		while (true)
		{
			if (num < intptr_0.Length)
			{
				IntPtr intPtr2 = intptr_0[num];
				if (intPtr2 != IntPtr.Zero)
				{
					string text = smethod_3(intPtr2);
					if (text.Contains(string_0))
					{
						zero = new IntPtr(User32.GetWindow(intPtr2.ToInt32(), GW.CHILD));
						while (zero != IntPtr.Zero)
						{
							intPtr = zero;
							zero = new IntPtr(User32.GetWindow(intPtr.ToInt32(), GW.CHILD));
						}
						text = smethod_3(intPtr);
						if (smethod_8(intPtr))
						{
							break;
						}
					}
				}
				num++;
				continue;
			}
			return IntPtr.Zero;
		}
		return intPtr;
	}

	public static bool smethod_7()
	{
		return smethod_5() != IntPtr.Zero;
	}

	public static bool smethod_8(IntPtr intptr_0)
	{
		User32.GetWindowRect(intptr_0, out var lpRect);
		return lpRect.bottom - lpRect.top > 400;
	}

	public static Bitmap smethod_9(Bitmap bitmap_0, Rectangle rectangle_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		Bitmap val = new Bitmap(rectangle_0.Width, rectangle_0.Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.DrawImage((Image)(object)bitmap_0, 0, 0, rectangle_0, (GraphicsUnit)2);
		val2.Dispose();
		return val;
	}

	public static Bitmap smethod_10(out Point point_0)
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		try
		{
			IntPtr intPtr = smethod_5();
			User32.GetWindowRect(intPtr, out var lpRect);
			point_0 = new Point(lpRect.left, lpRect.top);
			int nWidth = lpRect.right - lpRect.left;
			int nHeight = lpRect.bottom - lpRect.top;
			int windowDC = User32.GetWindowDC(intPtr.ToInt32());
			int num = GDI32.CreateCompatibleDC(windowDC);
			int num2 = GDI32.CreateCompatibleBitmap(windowDC, nWidth, nHeight);
			GDI32.SelectObject(num, num2);
			GDI32.BitBlt(num, 0, 0, nWidth, nHeight, windowDC, 0, 0, 13369376);
			Bitmap val = new Bitmap((Image)(object)Image.FromHbitmap(new IntPtr(num2)), ((Image)Image.FromHbitmap(new IntPtr(num2))).get_Width(), ((Image)Image.FromHbitmap(new IntPtr(num2))).get_Height());
			smethod_11(num2, windowDC, intPtr, num);
			GClass5 gClass = new GClass5(val);
			gClass.method_7();
			return val;
		}
		catch (Exception)
		{
			point_0 = default(Point);
			return null;
		}
	}

	public static void smethod_11(int int_0, int int_1, IntPtr intptr_0, int int_2)
	{
		User32.ReleaseDC(intptr_0.ToInt32(), int_1);
		GDI32.DeleteDC(int_2);
		GDI32.DeleteObject(int_0);
	}
}
