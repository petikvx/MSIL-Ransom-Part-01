using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

internal class Class1
{
	public delegate int Delegate0(int code, int wParam, ref Struct0 lParam);

	public struct Struct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;
	}

	private const int int_0 = 13;

	private const int int_1 = 256;

	private const int int_2 = 257;

	private const int int_3 = 260;

	private const int int_4 = 261;

	public List<Keys> list_0 = new List<Keys>();

	private IntPtr intptr_0 = IntPtr.Zero;

	[CompilerGenerated]
	private KeyEventHandler keyEventHandler_0;

	[CompilerGenerated]
	private KeyEventHandler keyEventHandler_1;

	public event KeyEventHandler Event_0
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = keyEventHandler_0;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref keyEventHandler_0, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = keyEventHandler_0;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref keyEventHandler_0, value2, val2);
			}
			while (val != val2);
		}
	}

	public event KeyEventHandler Event_1
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = keyEventHandler_1;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref keyEventHandler_1, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = keyEventHandler_1;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref keyEventHandler_1, value2, val2);
			}
			while (val != val2);
		}
	}

	public Class1()
	{
		method_0();
	}

	~Class1()
	{
		method_1();
	}

	public void method_0()
	{
		IntPtr hInstance = LoadLibrary(Class4.smethod_0("\ue4b0삲킴얶誸覺", 8));
		for (int num = 0; num == 0; num = 1)
		{
			intptr_0 = SetWindowsHookEx(13, method_2, hInstance, 0u);
		}
	}

	public void method_1()
	{
		UnhookWindowsHookEx(intptr_0);
	}

	public int method_2(int int_5, int int_6, ref Struct0 struct0_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		if (int_5 >= 0)
		{
			Keys val = (Keys)struct0_0.int_0;
			if (list_0.Contains(val))
			{
				KeyEventArgs val2 = new KeyEventArgs(val);
				if ((int_6 == 256 || int_6 == 260) && keyEventHandler_0 != null)
				{
					keyEventHandler_0.Invoke((object)this, val2);
				}
				else if ((int_6 == 257 || int_6 == 261) && keyEventHandler_1 != null)
				{
					keyEventHandler_1.Invoke((object)this, val2);
				}
				if (val2.get_Handled())
				{
					return 1;
				}
			}
		}
		return CallNextHookEx(intptr_0, int_5, int_6, ref struct0_0);
	}

	[DllImport("user32.dll")]
	private static extern IntPtr SetWindowsHookEx(int idHook, Delegate0 callback, IntPtr hInstance, uint threadId);

	[DllImport("user32.dll")]
	private static extern bool UnhookWindowsHookEx(IntPtr hInstance);

	[DllImport("user32.dll")]
	private static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref Struct0 lParam);

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string lpFileName);
}
