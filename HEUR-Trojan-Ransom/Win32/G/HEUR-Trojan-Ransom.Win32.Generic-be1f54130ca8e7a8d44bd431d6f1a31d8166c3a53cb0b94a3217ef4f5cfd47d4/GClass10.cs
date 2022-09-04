using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GClass10
{
	private struct Struct0
	{
		public uint uint_0;

		public uint uint_1;

		public Enum0 enum0_0;

		public uint uint_2;

		public UIntPtr uintptr_0;
	}

	[Flags]
	private enum Enum0 : uint
	{
		qkPAbrA5QHSKJLJ = 1u,
		LLKHF_INJECTED = 0x10u,
		LLKHF_ALTDOWN = 0x20u,
		LLKHF_UP = 0x80u
	}

	public delegate void GDelegate0(Keys Key);

	private delegate int Delegate0(int wPfwuOw9cUBTKno, IntPtr pOimShmzTUNVeGT, IntPtr WJktOTelwe1LXL3);

	private static GDelegate0 gdelegate0_0;

	private const int int_0 = 13;

	private const int int_1 = 0;

	private const int int_2 = 256;

	private const int int_3 = 257;

	private const int int_4 = 260;

	private const int int_5 = 261;

	private Delegate0 delegate0_0;

	private IntPtr intptr_0;

	public static event GDelegate0 Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			gdelegate0_0 = (GDelegate0)Delegate.Combine(gdelegate0_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			gdelegate0_0 = (GDelegate0)Delegate.Remove(gdelegate0_0, value);
		}
	}

	[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int SetWindowsHookEx(int int_6, Delegate0 delegate0_1, IntPtr intptr_1, int int_7);

	[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int CallNextHookEx(int int_6, int int_7, IntPtr intptr_1, IntPtr intptr_2);

	private int method_0(int int_6, IntPtr intptr_1, IntPtr intptr_2)
	{
		if (int_6 == 0)
		{
			if (intptr_1 == (IntPtr)256 || intptr_1 == (IntPtr)260)
			{
				GDelegate0 gDelegate = gdelegate0_0;
				if (gDelegate != null)
				{
					Struct0 @struct = default(Struct0);
					object? obj = Marshal.PtrToStructure(intptr_2, @struct.GetType());
					Struct0 struct2 = default(Struct0);
					gDelegate((Keys)checked((int)((obj != null) ? ((Struct0)obj) : struct2).uint_0));
				}
			}
		}
		return CallNextHookEx((int)IntPtr.Zero, int_6, intptr_1, intptr_2);
	}

	public GClass10()
	{
		delegate0_0 = method_0;
		intptr_0 = IntPtr.Zero;
		intptr_0 = (IntPtr)SetWindowsHookEx(13, delegate0_0, (IntPtr)Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
	}
}
