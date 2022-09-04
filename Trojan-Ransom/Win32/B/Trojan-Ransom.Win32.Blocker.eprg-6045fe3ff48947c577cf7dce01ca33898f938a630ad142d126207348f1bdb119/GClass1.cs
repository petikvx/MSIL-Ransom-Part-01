using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

public static class GClass1
{
	private delegate int Delegate0(int int_0, int int_1, IntPtr intptr_0);

	private struct Struct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;
	}

	private struct Struct1
	{
		public Struct2 struct2_0;

		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;
	}

	private struct Struct2
	{
		public int int_0;

		public int int_1;
	}

	private static Delegate0 delegate0_0;

	private static int int_0;

	private static int int_1;

	private static int int_2;

	private static Delegate0 delegate0_1;

	private static int int_3;

	private static MouseEventHandler mouseEventHandler_0;

	private static EventHandler<GEventArgs0> eventHandler_0;

	private static MouseEventHandler mouseEventHandler_1;

	private static EventHandler<GEventArgs0> eventHandler_1;

	private static MouseEventHandler mouseEventHandler_2;

	private static MouseEventHandler mouseEventHandler_3;

	private static MouseEventHandler mouseEventHandler_4;

	private static MouseEventHandler mouseEventHandler_5;

	private static MouseButtons mouseButtons_0;

	private static Timer timer_0;

	private static KeyPressEventHandler keyPressEventHandler_0;

	private static KeyEventHandler keyEventHandler_0;

	private static KeyEventHandler keyEventHandler_1;

	private static int smethod_0(int int_4, int int_5, IntPtr intptr_0)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if (int_4 >= 0)
		{
			Struct1 @struct = (Struct1)Marshal.PtrToStructure(intptr_0, typeof(Struct1));
			MouseButtons val = (MouseButtons)0;
			short num = 0;
			int num2 = 0;
			bool flag = false;
			bool flag2 = false;
			switch (int_5)
			{
			case 513:
				flag = true;
				val = (MouseButtons)1048576;
				num2 = 1;
				break;
			case 514:
				flag2 = true;
				val = (MouseButtons)1048576;
				num2 = 1;
				break;
			case 515:
				val = (MouseButtons)1048576;
				num2 = 2;
				break;
			case 516:
				flag = true;
				val = (MouseButtons)2097152;
				num2 = 1;
				break;
			case 517:
				flag2 = true;
				val = (MouseButtons)2097152;
				num2 = 1;
				break;
			case 518:
				val = (MouseButtons)2097152;
				num2 = 2;
				break;
			case 522:
				num = (short)((@struct.int_0 >> 16) & 0xFFFF);
				break;
			}
			GEventArgs0 gEventArgs = new GEventArgs0(val, num2, @struct.struct2_0.int_0, @struct.struct2_0.int_1, num);
			if (mouseEventHandler_3 != null && flag2)
			{
				mouseEventHandler_3.Invoke((object)null, (MouseEventArgs)(object)gEventArgs);
			}
			if (mouseEventHandler_2 != null && flag)
			{
				mouseEventHandler_2.Invoke((object)null, (MouseEventArgs)(object)gEventArgs);
			}
			if (mouseEventHandler_1 != null && num2 > 0)
			{
				mouseEventHandler_1.Invoke((object)null, (MouseEventArgs)(object)gEventArgs);
			}
			if (eventHandler_1 != null && num2 > 0)
			{
				eventHandler_1(null, gEventArgs);
			}
			if (mouseEventHandler_5 != null && num2 == 2)
			{
				mouseEventHandler_5.Invoke((object)null, (MouseEventArgs)(object)gEventArgs);
			}
			if (mouseEventHandler_4 != null && num != 0)
			{
				mouseEventHandler_4.Invoke((object)null, (MouseEventArgs)(object)gEventArgs);
			}
			if ((mouseEventHandler_0 != null || eventHandler_0 != null) && (int_1 != @struct.struct2_0.int_0 || int_2 != @struct.struct2_0.int_1))
			{
				int_1 = @struct.struct2_0.int_0;
				int_2 = @struct.struct2_0.int_1;
				if (mouseEventHandler_0 != null)
				{
					mouseEventHandler_0.Invoke((object)null, (MouseEventArgs)(object)gEventArgs);
				}
				if (eventHandler_0 != null)
				{
					eventHandler_0(null, gEventArgs);
				}
			}
			if (gEventArgs.method_0())
			{
				return -1;
			}
		}
		return CallNextHookEx(int_0, int_4, int_5, intptr_0);
	}

	private static void smethod_1()
	{
		if (int_0 == 0)
		{
			delegate0_0 = smethod_0;
			int_0 = SetWindowsHookEx(14, delegate0_0, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
			if (int_0 == 0)
			{
				Marshal.GetLastWin32Error();
			}
		}
	}

	private static void smethod_2()
	{
		if (mouseEventHandler_1 == null && mouseEventHandler_2 == null && mouseEventHandler_0 == null && mouseEventHandler_3 == null && eventHandler_1 == null && eventHandler_0 == null && mouseEventHandler_4 == null)
		{
			smethod_3();
		}
	}

	private static void smethod_3()
	{
		if (int_0 != 0)
		{
			int num = UnhookWindowsHookEx(int_0);
			int_0 = 0;
			delegate0_0 = null;
			if (num == 0)
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				throw new Win32Exception(lastWin32Error);
			}
		}
	}

	private static int smethod_4(int int_4, int int_5, IntPtr intptr_0)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		bool flag = false;
		if (int_4 >= 0)
		{
			Struct0 @struct = (Struct0)Marshal.PtrToStructure(intptr_0, typeof(Struct0));
			if (keyEventHandler_1 != null && (int_5 == 256 || int_5 == 260))
			{
				Keys val = (Keys)@struct.int_0;
				KeyEventArgs val2 = new KeyEventArgs(val);
				keyEventHandler_1.Invoke((object)null, val2);
				flag = val2.get_Handled();
			}
			if (keyPressEventHandler_0 != null && int_5 == 256)
			{
				bool flag2 = (GetKeyState(16) & 0x80) == 128;
				bool flag3 = ((GetKeyState(20) != 0) ? true : false);
				byte[] byte_ = new byte[256];
				GetKeyboardState(byte_);
				byte[] array = new byte[2];
				if (ToAscii(@struct.int_0, @struct.int_1, byte_, array, @struct.int_2) == 1)
				{
					char c = (char)array[0];
					if ((flag3 ^ flag2) && char.IsLetter(c))
					{
						c = char.ToUpper(c);
					}
					KeyPressEventArgs val3 = new KeyPressEventArgs(c);
					keyPressEventHandler_0.Invoke((object)null, val3);
					flag = flag || val3.get_Handled();
				}
			}
			if (keyEventHandler_0 != null && (int_5 == 257 || int_5 == 261))
			{
				Keys val = (Keys)@struct.int_0;
				KeyEventArgs val2 = new KeyEventArgs(val);
				keyEventHandler_0.Invoke((object)null, val2);
				flag = flag || val2.get_Handled();
			}
		}
		if (flag)
		{
			return -1;
		}
		return CallNextHookEx(int_3, int_4, int_5, intptr_0);
	}

	private static void smethod_5()
	{
		if (int_3 == 0)
		{
			delegate0_1 = smethod_4;
			int_3 = SetWindowsHookEx(13, delegate0_1, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
			if (int_3 == 0)
			{
				Marshal.GetLastWin32Error();
			}
		}
	}

	private static void smethod_6()
	{
		if (keyEventHandler_1 == null && keyEventHandler_0 == null && keyPressEventHandler_0 == null)
		{
			smethod_7();
		}
	}

	private static void smethod_7()
	{
		if (int_3 != 0)
		{
			int num = UnhookWindowsHookEx(int_3);
			int_3 = 0;
			delegate0_1 = null;
			if (num == 0)
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				throw new Win32Exception(lastWin32Error);
			}
		}
	}

	private static void smethod_8(MouseEventHandler mouseEventHandler_6)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_0;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_6);
			val = Interlocked.CompareExchange(ref mouseEventHandler_0, value, val2);
		}
		while (val != val2);
	}

	private static void smethod_9(MouseEventHandler mouseEventHandler_6)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_0;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_6);
			val = Interlocked.CompareExchange(ref mouseEventHandler_0, value, val2);
		}
		while (val != val2);
	}

	public static void smethod_10(MouseEventHandler mouseEventHandler_6)
	{
		smethod_1();
		smethod_8(mouseEventHandler_6);
	}

	public static void smethod_11(MouseEventHandler mouseEventHandler_6)
	{
		smethod_9(mouseEventHandler_6);
		smethod_2();
	}

	private static void smethod_12(EventHandler<GEventArgs0> eventHandler_2)
	{
		EventHandler<GEventArgs0> eventHandler = eventHandler_0;
		EventHandler<GEventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Combine(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private static void smethod_13(EventHandler<GEventArgs0> eventHandler_2)
	{
		EventHandler<GEventArgs0> eventHandler = eventHandler_0;
		EventHandler<GEventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Remove(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public static void smethod_14(EventHandler<GEventArgs0> eventHandler_2)
	{
		smethod_1();
		smethod_12(eventHandler_2);
	}

	public static void smethod_15(EventHandler<GEventArgs0> eventHandler_2)
	{
		smethod_13(eventHandler_2);
		smethod_2();
	}

	private static void smethod_16(MouseEventHandler mouseEventHandler_6)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_1;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_6);
			val = Interlocked.CompareExchange(ref mouseEventHandler_1, value, val2);
		}
		while (val != val2);
	}

	private static void smethod_17(MouseEventHandler mouseEventHandler_6)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_1;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_6);
			val = Interlocked.CompareExchange(ref mouseEventHandler_1, value, val2);
		}
		while (val != val2);
	}

	public static void smethod_18(MouseEventHandler mouseEventHandler_6)
	{
		smethod_1();
		smethod_16(mouseEventHandler_6);
	}

	public static void smethod_19(MouseEventHandler mouseEventHandler_6)
	{
		smethod_17(mouseEventHandler_6);
		smethod_2();
	}

	private static void smethod_20(EventHandler<GEventArgs0> eventHandler_2)
	{
		EventHandler<GEventArgs0> eventHandler = eventHandler_1;
		EventHandler<GEventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Combine(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	private static void smethod_21(EventHandler<GEventArgs0> eventHandler_2)
	{
		EventHandler<GEventArgs0> eventHandler = eventHandler_1;
		EventHandler<GEventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Remove(eventHandler2, eventHandler_2);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public static void smethod_22(EventHandler<GEventArgs0> eventHandler_2)
	{
		smethod_1();
		smethod_20(eventHandler_2);
	}

	public static void smethod_23(EventHandler<GEventArgs0> eventHandler_2)
	{
		smethod_21(eventHandler_2);
		smethod_2();
	}

	private static void smethod_24(MouseEventHandler mouseEventHandler_6)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_2;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_6);
			val = Interlocked.CompareExchange(ref mouseEventHandler_2, value, val2);
		}
		while (val != val2);
	}

	private static void smethod_25(MouseEventHandler mouseEventHandler_6)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_2;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_6);
			val = Interlocked.CompareExchange(ref mouseEventHandler_2, value, val2);
		}
		while (val != val2);
	}

	public static void smethod_26(MouseEventHandler mouseEventHandler_6)
	{
		smethod_1();
		smethod_24(mouseEventHandler_6);
	}

	public static void smethod_27(MouseEventHandler mouseEventHandler_6)
	{
		smethod_25(mouseEventHandler_6);
		smethod_2();
	}

	private static void smethod_28(MouseEventHandler mouseEventHandler_6)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_3;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_6);
			val = Interlocked.CompareExchange(ref mouseEventHandler_3, value, val2);
		}
		while (val != val2);
	}

	private static void smethod_29(MouseEventHandler mouseEventHandler_6)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_3;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_6);
			val = Interlocked.CompareExchange(ref mouseEventHandler_3, value, val2);
		}
		while (val != val2);
	}

	public static void smethod_30(MouseEventHandler mouseEventHandler_6)
	{
		smethod_1();
		smethod_28(mouseEventHandler_6);
	}

	public static void smethod_31(MouseEventHandler mouseEventHandler_6)
	{
		smethod_29(mouseEventHandler_6);
		smethod_2();
	}

	private static void smethod_32(MouseEventHandler mouseEventHandler_6)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_4;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_6);
			val = Interlocked.CompareExchange(ref mouseEventHandler_4, value, val2);
		}
		while (val != val2);
	}

	private static void smethod_33(MouseEventHandler mouseEventHandler_6)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_4;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_6);
			val = Interlocked.CompareExchange(ref mouseEventHandler_4, value, val2);
		}
		while (val != val2);
	}

	public static void smethod_34(MouseEventHandler mouseEventHandler_6)
	{
		smethod_1();
		smethod_32(mouseEventHandler_6);
	}

	public static void smethod_35(MouseEventHandler mouseEventHandler_6)
	{
		smethod_33(mouseEventHandler_6);
		smethod_2();
	}

	private static void smethod_36(MouseEventHandler mouseEventHandler_6)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_5;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_6);
			val = Interlocked.CompareExchange(ref mouseEventHandler_5, value, val2);
		}
		while (val != val2);
	}

	private static void smethod_37(MouseEventHandler mouseEventHandler_6)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		MouseEventHandler val = mouseEventHandler_5;
		MouseEventHandler val2;
		do
		{
			val2 = val;
			MouseEventHandler value = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)mouseEventHandler_6);
			val = Interlocked.CompareExchange(ref mouseEventHandler_5, value, val2);
		}
		while (val != val2);
	}

	public static void smethod_38(MouseEventHandler mouseEventHandler_6)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		smethod_1();
		if (mouseEventHandler_5 == null)
		{
			Timer val = new Timer();
			val.set_Interval(GetDoubleClickTime());
			val.set_Enabled(false);
			timer_0 = val;
			timer_0.add_Tick((EventHandler)smethod_40);
			smethod_30(new MouseEventHandler(smethod_41));
		}
		smethod_36(mouseEventHandler_6);
	}

	public static void smethod_39(MouseEventHandler mouseEventHandler_6)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		if (mouseEventHandler_5 != null)
		{
			smethod_37(mouseEventHandler_6);
			if (mouseEventHandler_5 == null)
			{
				smethod_31(new MouseEventHandler(smethod_41));
				timer_0.remove_Tick((EventHandler)smethod_40);
				timer_0 = null;
			}
		}
		smethod_2();
	}

	private static void smethod_40(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		timer_0.set_Enabled(false);
		mouseButtons_0 = (MouseButtons)0;
	}

	private static void smethod_41(object sender, MouseEventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (e.get_Clicks() < 1)
		{
			return;
		}
		if (((object)e.get_Button()).Equals((object?)mouseButtons_0))
		{
			if (mouseEventHandler_5 != null)
			{
				mouseEventHandler_5.Invoke((object)null, e);
			}
			timer_0.set_Enabled(false);
			mouseButtons_0 = (MouseButtons)0;
		}
		else
		{
			timer_0.set_Enabled(true);
			mouseButtons_0 = e.get_Button();
		}
	}

	private static void smethod_42(KeyPressEventHandler keyPressEventHandler_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		KeyPressEventHandler val = keyPressEventHandler_0;
		KeyPressEventHandler val2;
		do
		{
			val2 = val;
			KeyPressEventHandler value = (KeyPressEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)keyPressEventHandler_1);
			val = Interlocked.CompareExchange(ref keyPressEventHandler_0, value, val2);
		}
		while (val != val2);
	}

	private static void smethod_43(KeyPressEventHandler keyPressEventHandler_1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		KeyPressEventHandler val = keyPressEventHandler_0;
		KeyPressEventHandler val2;
		do
		{
			val2 = val;
			KeyPressEventHandler value = (KeyPressEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)keyPressEventHandler_1);
			val = Interlocked.CompareExchange(ref keyPressEventHandler_0, value, val2);
		}
		while (val != val2);
	}

	public static void smethod_44(KeyPressEventHandler keyPressEventHandler_1)
	{
		smethod_5();
		smethod_42(keyPressEventHandler_1);
	}

	public static void smethod_45(KeyPressEventHandler keyPressEventHandler_1)
	{
		smethod_43(keyPressEventHandler_1);
		smethod_6();
	}

	private static void smethod_46(KeyEventHandler keyEventHandler_2)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		KeyEventHandler val = keyEventHandler_0;
		KeyEventHandler val2;
		do
		{
			val2 = val;
			KeyEventHandler value = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)keyEventHandler_2);
			val = Interlocked.CompareExchange(ref keyEventHandler_0, value, val2);
		}
		while (val != val2);
	}

	private static void smethod_47(KeyEventHandler keyEventHandler_2)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		KeyEventHandler val = keyEventHandler_0;
		KeyEventHandler val2;
		do
		{
			val2 = val;
			KeyEventHandler value = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)keyEventHandler_2);
			val = Interlocked.CompareExchange(ref keyEventHandler_0, value, val2);
		}
		while (val != val2);
	}

	public static void smethod_48(KeyEventHandler keyEventHandler_2)
	{
		smethod_5();
		smethod_46(keyEventHandler_2);
	}

	public static void smethod_49(KeyEventHandler keyEventHandler_2)
	{
		smethod_47(keyEventHandler_2);
		smethod_6();
	}

	private static void smethod_50(KeyEventHandler keyEventHandler_2)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		KeyEventHandler val = keyEventHandler_1;
		KeyEventHandler val2;
		do
		{
			val2 = val;
			KeyEventHandler value = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)keyEventHandler_2);
			val = Interlocked.CompareExchange(ref keyEventHandler_1, value, val2);
		}
		while (val != val2);
	}

	private static void smethod_51(KeyEventHandler keyEventHandler_2)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		KeyEventHandler val = keyEventHandler_1;
		KeyEventHandler val2;
		do
		{
			val2 = val;
			KeyEventHandler value = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)keyEventHandler_2);
			val = Interlocked.CompareExchange(ref keyEventHandler_1, value, val2);
		}
		while (val != val2);
	}

	public static void smethod_52(KeyEventHandler keyEventHandler_2)
	{
		smethod_5();
		smethod_50(keyEventHandler_2);
	}

	public static void smethod_53(KeyEventHandler keyEventHandler_2)
	{
		smethod_51(keyEventHandler_2);
		smethod_6();
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int CallNextHookEx(int int_4, int int_5, int int_6, IntPtr intptr_0);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int SetWindowsHookEx(int int_4, Delegate0 delegate0_2, IntPtr intptr_0, int int_5);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int int_4);

	[DllImport("user32")]
	public static extern int GetDoubleClickTime();

	[DllImport("user32")]
	private static extern int ToAscii(int int_4, int int_5, byte[] byte_0, byte[] byte_1, int int_6);

	[DllImport("user32")]
	private static extern int GetKeyboardState(byte[] byte_0);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern short GetKeyState(int int_4);
}
