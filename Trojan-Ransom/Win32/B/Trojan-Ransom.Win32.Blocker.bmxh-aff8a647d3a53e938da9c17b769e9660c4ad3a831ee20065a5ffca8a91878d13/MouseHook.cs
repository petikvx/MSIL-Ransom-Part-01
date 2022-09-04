using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class MouseHook
{
	public delegate int MouseHookCallBack(int nCode, IntPtr wParam, IntPtr lParam);

	public struct Point
	{
		public int x;

		public int y;
	}

	public struct MouseHookStruct
	{
		public Point pt;

		public int hwnd;

		public int wHitTestCode;

		public int dwExtraInfo;
	}

	private const int MOUSEEVENTF_LEFTDOWN = 2;

	private const int MOUSEEVENTF_LEFTUP = 4;

	private static int m_iMouseHandle = 0;

	private const int HC_ACTION = 0;

	private const int WH_MOUSE_LL = 14;

	private const int WM_LBUTTONDOWN = 513;

	private const int WM_LBUTTONUP = 514;

	public static Bitmap img1 = null;

	public static Bitmap img2 = null;

	public static Bitmap img3 = null;

	public static Bitmap img4 = null;

	private static MouseEventHandler MouseClickEvent;

	private static MouseEventHandler MouseMoveEvent;

	public static bool IsBankFound = false;

	private static MouseHookCallBack m_clsMouseHookCallBack;

	public static event MouseEventHandler MouseClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			MouseClickEvent = (MouseEventHandler)Delegate.Combine((Delegate?)(object)MouseClickEvent, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			MouseClickEvent = (MouseEventHandler)Delegate.Remove((Delegate?)(object)MouseClickEvent, (Delegate?)(object)value);
		}
	}

	public static event MouseEventHandler MouseMove
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			MouseMoveEvent = (MouseEventHandler)Delegate.Combine((Delegate?)(object)MouseMoveEvent, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			MouseMoveEvent = (MouseEventHandler)Delegate.Remove((Delegate?)(object)MouseMoveEvent, (Delegate?)(object)value);
		}
	}

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, IntPtr dwExtraInfo);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string ModuleName);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern object SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

	[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern int SetWindowsHookEx(int idHook, MouseHookCallBack HookProc, IntPtr hInstance, int wParam);

	[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern int CallNextHookEx(int idHook, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern bool UnhookWindowsHookEx(int idHook);

	public static void BFound()
	{
		IsBankFound = true;
	}

	private static int MouseProc(int nCode, IntPtr wParam, IntPtr lParam)
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		checked
		{
			if (nCode == 0)
			{
				MouseHookStruct mouseHookStruct = default(MouseHookStruct);
				object? obj = Marshal.PtrToStructure(lParam, mouseHookStruct.GetType());
				MouseHookStruct mouseHookStruct2 = default(MouseHookStruct);
				mouseHookStruct = ((obj != null) ? ((MouseHookStruct)obj) : mouseHookStruct2);
				switch (wParam.ToInt32())
				{
				case 513:
					if (!IsBankFound)
					{
						break;
					}
					if (PinFinder.PinClicks >= 5)
					{
						try
						{
							UnhookMouse();
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
						try
						{
							PinFinder.StartP(img1, img2, img3, img4);
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						break;
					}
					try
					{
						Bitmap val = new Bitmap(PinFinder.ScreenDimensions.Width, PinFinder.ScreenDimensions.Height, (PixelFormat)2498570);
						Graphics val2 = Graphics.FromImage((Image)(object)val);
						val2.CopyFromScreen(PinFinder.ScreenRectangle.X, PinFinder.ScreenRectangle.Y, 0, 0, PinFinder.ScreenRectangle.Size, (CopyPixelOperation)13369376);
						Bitmap val3 = val;
						if (PinFinder.PinClicks == 1)
						{
							img1 = val3;
							Console.WriteLine("Image 1 Taken");
						}
						else if (PinFinder.PinClicks == 2)
						{
							img2 = val3;
							Console.WriteLine("Image 2 Taken");
						}
						else if (PinFinder.PinClicks == 3)
						{
							img3 = val3;
							Console.WriteLine("Image 3 Taken");
						}
						else if (PinFinder.PinClicks == 4)
						{
							img4 = val3;
							Console.WriteLine("Image 4 Taken");
						}
						PinFinder.PinClicks++;
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					break;
				}
			}
			return CallNextHookEx(m_iMouseHandle, nCode, wParam, lParam);
		}
	}

	public static void HookMouse()
	{
		m_clsMouseHookCallBack = MouseProc;
		MouseHookCallBack clsMouseHookCallBack = m_clsMouseHookCallBack;
		string ModuleName = Process.GetCurrentProcess().MainModule!.ModuleName;
		m_iMouseHandle = SetWindowsHookEx(14, clsMouseHookCallBack, GetModuleHandleA(ref ModuleName), 0);
		if (m_iMouseHandle == 0)
		{
			throw new Exception("Mouse hook failed.");
		}
	}

	public static void UnhookMouse()
	{
		if (m_iMouseHandle != 0)
		{
			UnhookWindowsHookEx(m_iMouseHandle);
		}
	}
}
