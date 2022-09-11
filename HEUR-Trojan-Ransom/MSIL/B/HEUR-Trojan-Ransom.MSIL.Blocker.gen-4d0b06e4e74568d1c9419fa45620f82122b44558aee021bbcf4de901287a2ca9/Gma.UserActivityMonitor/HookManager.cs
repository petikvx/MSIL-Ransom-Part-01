using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Gma.UserActivityMonitor;

public static class HookManager
{
	private delegate int HookProc(int nCode, int wParam, IntPtr lParam);

	private struct Point
	{
		public int X;

		public int Y;
	}

	private struct MouseLLHookStruct
	{
		public Point Point;

		public int MouseData;

		public int Flags;

		public int Time;

		public int ExtraInfo;
	}

	private struct KeyboardHookStruct
	{
		public int VirtualKeyCode;

		public int ScanCode;

		public int Flags;

		public int Time;

		public int ExtraInfo;
	}

	private static HookProc s_MouseDelegate;

	private static int s_MouseHookHandle;

	private static int m_OldX;

	private static int m_OldY;

	private static HookProc s_KeyboardDelegate;

	private static int s_KeyboardHookHandle;

	private static MouseButtons s_PrevClickedButton;

	private static Timer s_DoubleClickTimer;

	private const int WH_MOUSE_LL = 14;

	private const int WH_KEYBOARD_LL = 13;

	private const int WH_MOUSE = 7;

	private const int WH_KEYBOARD = 2;

	private const int WM_MOUSEMOVE = 512;

	private const int WM_LBUTTONDOWN = 513;

	private const int WM_RBUTTONDOWN = 516;

	private const int WM_MBUTTONDOWN = 519;

	private const int WM_LBUTTONUP = 514;

	private const int WM_RBUTTONUP = 517;

	private const int WM_MBUTTONUP = 520;

	private const int WM_LBUTTONDBLCLK = 515;

	private const int WM_RBUTTONDBLCLK = 518;

	private const int WM_MBUTTONDBLCLK = 521;

	private const int WM_MOUSEWHEEL = 522;

	private const int WM_KEYDOWN = 256;

	private const int WM_KEYUP = 257;

	private const int WM_SYSKEYDOWN = 260;

	private const int WM_SYSKEYUP = 261;

	private const byte VK_SHIFT = 16;

	private const byte VK_CAPITAL = 20;

	private const byte VK_NUMLOCK = 144;

	private static event MouseEventHandler s_MouseMove
	{
		[CompilerGenerated]
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			MouseEventHandler val = HookManager.s_MouseMove;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_MouseMove, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			MouseEventHandler val = HookManager.s_MouseMove;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_MouseMove, value2, val2);
			}
			while (val != val2);
		}
	}

	public static event MouseEventHandler MouseMove
	{
		add
		{
			EnsureSubscribedToGlobalMouseEvents();
			s_MouseMove += value;
		}
		remove
		{
			s_MouseMove -= value;
			TryUnsubscribeFromGlobalMouseEvents();
		}
	}

	private static event EventHandler<MouseEventExtArgs> s_MouseMoveExt;

	public static event EventHandler<MouseEventExtArgs> MouseMoveExt
	{
		add
		{
			EnsureSubscribedToGlobalMouseEvents();
			s_MouseMoveExt += value;
		}
		remove
		{
			s_MouseMoveExt -= value;
			TryUnsubscribeFromGlobalMouseEvents();
		}
	}

	private static event MouseEventHandler s_MouseClick
	{
		[CompilerGenerated]
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			MouseEventHandler val = HookManager.s_MouseClick;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_MouseClick, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			MouseEventHandler val = HookManager.s_MouseClick;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_MouseClick, value2, val2);
			}
			while (val != val2);
		}
	}

	public static event MouseEventHandler MouseClick
	{
		add
		{
			EnsureSubscribedToGlobalMouseEvents();
			s_MouseClick += value;
		}
		remove
		{
			s_MouseClick -= value;
			TryUnsubscribeFromGlobalMouseEvents();
		}
	}

	private static event EventHandler<MouseEventExtArgs> s_MouseClickExt;

	public static event EventHandler<MouseEventExtArgs> MouseClickExt
	{
		add
		{
			EnsureSubscribedToGlobalMouseEvents();
			s_MouseClickExt += value;
		}
		remove
		{
			s_MouseClickExt -= value;
			TryUnsubscribeFromGlobalMouseEvents();
		}
	}

	private static event MouseEventHandler s_MouseDown
	{
		[CompilerGenerated]
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			MouseEventHandler val = HookManager.s_MouseDown;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_MouseDown, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			MouseEventHandler val = HookManager.s_MouseDown;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_MouseDown, value2, val2);
			}
			while (val != val2);
		}
	}

	public static event MouseEventHandler MouseDown
	{
		add
		{
			EnsureSubscribedToGlobalMouseEvents();
			s_MouseDown += value;
		}
		remove
		{
			s_MouseDown -= value;
			TryUnsubscribeFromGlobalMouseEvents();
		}
	}

	private static event MouseEventHandler s_MouseUp
	{
		[CompilerGenerated]
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			MouseEventHandler val = HookManager.s_MouseUp;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_MouseUp, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			MouseEventHandler val = HookManager.s_MouseUp;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_MouseUp, value2, val2);
			}
			while (val != val2);
		}
	}

	public static event MouseEventHandler MouseUp
	{
		add
		{
			EnsureSubscribedToGlobalMouseEvents();
			s_MouseUp += value;
		}
		remove
		{
			s_MouseUp -= value;
			TryUnsubscribeFromGlobalMouseEvents();
		}
	}

	private static event MouseEventHandler s_MouseWheel
	{
		[CompilerGenerated]
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			MouseEventHandler val = HookManager.s_MouseWheel;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_MouseWheel, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			MouseEventHandler val = HookManager.s_MouseWheel;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_MouseWheel, value2, val2);
			}
			while (val != val2);
		}
	}

	public static event MouseEventHandler MouseWheel
	{
		add
		{
			EnsureSubscribedToGlobalMouseEvents();
			s_MouseWheel += value;
		}
		remove
		{
			s_MouseWheel -= value;
			TryUnsubscribeFromGlobalMouseEvents();
		}
	}

	private static event MouseEventHandler s_MouseDoubleClick
	{
		[CompilerGenerated]
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			MouseEventHandler val = HookManager.s_MouseDoubleClick;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_MouseDoubleClick, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			MouseEventHandler val = HookManager.s_MouseDoubleClick;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_MouseDoubleClick, value2, val2);
			}
			while (val != val2);
		}
	}

	public static event MouseEventHandler MouseDoubleClick
	{
		add
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			EnsureSubscribedToGlobalMouseEvents();
			if (HookManager.s_MouseDoubleClick == null)
			{
				Timer val = new Timer();
				val.set_Interval(GetDoubleClickTime());
				val.set_Enabled(false);
				s_DoubleClickTimer = val;
				s_DoubleClickTimer.add_Tick((EventHandler)DoubleClickTimeElapsed);
				MouseUp += new MouseEventHandler(OnMouseUp);
			}
			s_MouseDoubleClick += value;
		}
		remove
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			if (HookManager.s_MouseDoubleClick != null)
			{
				s_MouseDoubleClick -= value;
				if (HookManager.s_MouseDoubleClick == null)
				{
					MouseUp -= new MouseEventHandler(OnMouseUp);
					s_DoubleClickTimer.remove_Tick((EventHandler)DoubleClickTimeElapsed);
					s_DoubleClickTimer = null;
				}
			}
			TryUnsubscribeFromGlobalMouseEvents();
		}
	}

	private static event KeyPressEventHandler s_KeyPress
	{
		[CompilerGenerated]
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			KeyPressEventHandler val = HookManager.s_KeyPress;
			KeyPressEventHandler val2;
			do
			{
				val2 = val;
				KeyPressEventHandler value2 = (KeyPressEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_KeyPress, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			KeyPressEventHandler val = HookManager.s_KeyPress;
			KeyPressEventHandler val2;
			do
			{
				val2 = val;
				KeyPressEventHandler value2 = (KeyPressEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_KeyPress, value2, val2);
			}
			while (val != val2);
		}
	}

	public static event KeyPressEventHandler KeyPress
	{
		add
		{
			EnsureSubscribedToGlobalKeyboardEvents();
			s_KeyPress += value;
		}
		remove
		{
			s_KeyPress -= value;
			TryUnsubscribeFromGlobalKeyboardEvents();
		}
	}

	private static event KeyEventHandler s_KeyUp
	{
		[CompilerGenerated]
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			KeyEventHandler val = HookManager.s_KeyUp;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_KeyUp, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			KeyEventHandler val = HookManager.s_KeyUp;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_KeyUp, value2, val2);
			}
			while (val != val2);
		}
	}

	public static event KeyEventHandler KeyUp
	{
		add
		{
			EnsureSubscribedToGlobalKeyboardEvents();
			s_KeyUp += value;
		}
		remove
		{
			s_KeyUp -= value;
			TryUnsubscribeFromGlobalKeyboardEvents();
		}
	}

	private static event KeyEventHandler s_KeyDown
	{
		[CompilerGenerated]
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			KeyEventHandler val = HookManager.s_KeyDown;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_KeyDown, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			KeyEventHandler val = HookManager.s_KeyDown;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref HookManager.s_KeyDown, value2, val2);
			}
			while (val != val2);
		}
	}

	public static event KeyEventHandler KeyDown
	{
		add
		{
			EnsureSubscribedToGlobalKeyboardEvents();
			s_KeyDown += value;
		}
		remove
		{
			s_KeyDown -= value;
			TryUnsubscribeFromGlobalKeyboardEvents();
		}
	}

	private static int MouseHookProc(int nCode, int wParam, IntPtr lParam)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		if (nCode >= 0)
		{
			MouseLLHookStruct mouseLLHookStruct = (MouseLLHookStruct)Marshal.PtrToStructure(lParam, typeof(MouseLLHookStruct));
			MouseButtons buttons = (MouseButtons)0;
			short num = 0;
			int num2 = 0;
			bool flag = false;
			bool flag2 = false;
			switch (wParam)
			{
			case 513:
				flag = true;
				buttons = (MouseButtons)1048576;
				num2 = 1;
				break;
			case 514:
				flag2 = true;
				buttons = (MouseButtons)1048576;
				num2 = 1;
				break;
			case 515:
				buttons = (MouseButtons)1048576;
				num2 = 2;
				break;
			case 516:
				flag = true;
				buttons = (MouseButtons)2097152;
				num2 = 1;
				break;
			case 517:
				flag2 = true;
				buttons = (MouseButtons)2097152;
				num2 = 1;
				break;
			case 518:
				buttons = (MouseButtons)2097152;
				num2 = 2;
				break;
			case 522:
				num = (short)((mouseLLHookStruct.MouseData >> 16) & 0xFFFF);
				break;
			}
			MouseEventExtArgs mouseEventExtArgs = new MouseEventExtArgs(buttons, num2, mouseLLHookStruct.Point.X, mouseLLHookStruct.Point.Y, num);
			if (HookManager.s_MouseUp != null && flag2)
			{
				HookManager.s_MouseUp.Invoke((object)null, (MouseEventArgs)(object)mouseEventExtArgs);
			}
			if (HookManager.s_MouseDown != null && flag)
			{
				HookManager.s_MouseDown.Invoke((object)null, (MouseEventArgs)(object)mouseEventExtArgs);
			}
			if (HookManager.s_MouseClick != null && num2 > 0)
			{
				HookManager.s_MouseClick.Invoke((object)null, (MouseEventArgs)(object)mouseEventExtArgs);
			}
			if (HookManager.s_MouseClickExt != null && num2 > 0)
			{
				HookManager.s_MouseClickExt(null, mouseEventExtArgs);
			}
			if (HookManager.s_MouseDoubleClick != null && num2 == 2)
			{
				HookManager.s_MouseDoubleClick.Invoke((object)null, (MouseEventArgs)(object)mouseEventExtArgs);
			}
			if (HookManager.s_MouseWheel != null && num != 0)
			{
				HookManager.s_MouseWheel.Invoke((object)null, (MouseEventArgs)(object)mouseEventExtArgs);
			}
			if ((HookManager.s_MouseMove != null || HookManager.s_MouseMoveExt != null) && (m_OldX != mouseLLHookStruct.Point.X || m_OldY != mouseLLHookStruct.Point.Y))
			{
				m_OldX = mouseLLHookStruct.Point.X;
				m_OldY = mouseLLHookStruct.Point.Y;
				if (HookManager.s_MouseMove != null)
				{
					HookManager.s_MouseMove.Invoke((object)null, (MouseEventArgs)(object)mouseEventExtArgs);
				}
				if (HookManager.s_MouseMoveExt != null)
				{
					HookManager.s_MouseMoveExt(null, mouseEventExtArgs);
				}
			}
			if (mouseEventExtArgs.Handled)
			{
				return -1;
			}
		}
		return CallNextHookEx(s_MouseHookHandle, nCode, wParam, lParam);
	}

	private static void EnsureSubscribedToGlobalMouseEvents()
	{
		if (s_MouseHookHandle == 0)
		{
			s_MouseDelegate = MouseHookProc;
			s_MouseHookHandle = SetWindowsHookEx(14, s_MouseDelegate, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
			if (s_MouseHookHandle == 0)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
		}
	}

	private static void TryUnsubscribeFromGlobalMouseEvents()
	{
		if (HookManager.s_MouseClick == null && HookManager.s_MouseDown == null && HookManager.s_MouseMove == null && HookManager.s_MouseUp == null && HookManager.s_MouseClickExt == null && HookManager.s_MouseMoveExt == null && HookManager.s_MouseWheel == null)
		{
			ForceUnsunscribeFromGlobalMouseEvents();
		}
	}

	private static void ForceUnsunscribeFromGlobalMouseEvents()
	{
		if (s_MouseHookHandle != 0)
		{
			int num = UnhookWindowsHookEx(s_MouseHookHandle);
			s_MouseHookHandle = 0;
			s_MouseDelegate = null;
			if (num == 0)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
		}
	}

	private static int KeyboardHookProc(int nCode, int wParam, IntPtr lParam)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		bool flag = false;
		if (nCode >= 0)
		{
			KeyboardHookStruct keyboardHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));
			if (HookManager.s_KeyDown != null && (wParam == 256 || wParam == 260))
			{
				KeyEventArgs val = new KeyEventArgs((Keys)keyboardHookStruct.VirtualKeyCode);
				HookManager.s_KeyDown.Invoke((object)null, val);
				flag = val.get_Handled();
			}
			if (HookManager.s_KeyPress != null && wParam == 256)
			{
				bool flag2 = (GetKeyState(16) & 0x80) == 128;
				bool flag3 = ((GetKeyState(20) != 0) ? true : false);
				byte[] array = new byte[256];
				GetKeyboardState(array);
				byte[] array2 = new byte[2];
				if (ToAscii(keyboardHookStruct.VirtualKeyCode, keyboardHookStruct.ScanCode, array, array2, keyboardHookStruct.Flags) == 1)
				{
					char c = (char)array2[0];
					if ((flag3 ^ flag2) && char.IsLetter(c))
					{
						c = char.ToUpper(c);
					}
					KeyPressEventArgs val2 = new KeyPressEventArgs(c);
					HookManager.s_KeyPress.Invoke((object)null, val2);
					flag = flag || val2.get_Handled();
				}
			}
			if (HookManager.s_KeyUp != null && (wParam == 257 || wParam == 261))
			{
				KeyEventArgs val3 = new KeyEventArgs((Keys)keyboardHookStruct.VirtualKeyCode);
				HookManager.s_KeyUp.Invoke((object)null, val3);
				flag = flag || val3.get_Handled();
			}
		}
		if (flag)
		{
			return -1;
		}
		return CallNextHookEx(s_KeyboardHookHandle, nCode, wParam, lParam);
	}

	private static void EnsureSubscribedToGlobalKeyboardEvents()
	{
		if (s_KeyboardHookHandle == 0)
		{
			s_KeyboardDelegate = KeyboardHookProc;
			s_KeyboardHookHandle = SetWindowsHookEx(13, s_KeyboardDelegate, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
			if (s_KeyboardHookHandle == 0)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
		}
	}

	private static void TryUnsubscribeFromGlobalKeyboardEvents()
	{
		if (HookManager.s_KeyDown == null && HookManager.s_KeyUp == null && HookManager.s_KeyPress == null)
		{
			ForceUnsunscribeFromGlobalKeyboardEvents();
		}
	}

	private static void ForceUnsunscribeFromGlobalKeyboardEvents()
	{
		if (s_KeyboardHookHandle != 0)
		{
			int num = UnhookWindowsHookEx(s_KeyboardHookHandle);
			s_KeyboardHookHandle = 0;
			s_KeyboardDelegate = null;
			if (num == 0)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
		}
	}

	private static void DoubleClickTimeElapsed(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		s_DoubleClickTimer.set_Enabled(false);
		s_PrevClickedButton = (MouseButtons)0;
	}

	private static void OnMouseUp(object sender, MouseEventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		if (e.get_Clicks() < 1)
		{
			return;
		}
		MouseButtons button = e.get_Button();
		if (((object)(MouseButtons)(ref button)).Equals((object?)s_PrevClickedButton))
		{
			if (HookManager.s_MouseDoubleClick != null)
			{
				HookManager.s_MouseDoubleClick.Invoke((object)null, e);
			}
			s_DoubleClickTimer.set_Enabled(false);
			s_PrevClickedButton = (MouseButtons)0;
		}
		else
		{
			s_DoubleClickTimer.set_Enabled(true);
			s_PrevClickedButton = e.get_Button();
		}
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, int dwThreadId);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int idHook);

	[DllImport("user32")]
	public static extern int GetDoubleClickTime();

	[DllImport("user32")]
	private static extern int ToAscii(int uVirtKey, int uScanCode, byte[] lpbKeyState, byte[] lpwTransKey, int fuState);

	[DllImport("user32")]
	private static extern int GetKeyboardState(byte[] pbKeyState);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern short GetKeyState(int vKey);
}
