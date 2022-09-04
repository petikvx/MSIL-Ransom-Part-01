using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class Class6
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
		LLKHF_EXTENDED = 1u,
		LLKHF_INJECTED = 0x10u,
		LLKHF_ALTDOWN = 0x20u,
		LLKHF_UP = 0x80u
	}

	public delegate void Delegate0(Keys Key);

	public delegate void Delegate1(Keys Key);

	private delegate int Delegate2(int nCode, IntPtr wParam, IntPtr lParam);

	private static Delegate0 delegate0_0;

	private static Delegate1 delegate1_0;

	private const int int_0 = 13;

	private const int int_1 = 0;

	private const int int_2 = 256;

	private const int int_3 = 257;

	private const int int_4 = 260;

	private const int int_5 = 261;

	private Delegate2 delegate2_0;

	private IntPtr intptr_0;

	public static event Delegate0 Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			delegate0_0 = (Delegate0)Delegate.Combine(delegate0_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			delegate0_0 = (Delegate0)Delegate.Remove(delegate0_0, value);
		}
	}

	public static event Delegate1 Event_1
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			delegate1_0 = (Delegate1)Delegate.Combine(delegate1_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			delegate1_0 = (Delegate1)Delegate.Remove(delegate1_0, value);
		}
	}

	[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int SetWindowsHookEx(int int_6, Delegate2 delegate2_1, IntPtr intptr_1, int int_7);

	[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int CallNextHookEx(int int_6, int int_7, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern bool UnhookWindowsHookEx(int int_6);

	private int method_0(int int_6, IntPtr intptr_1, IntPtr intptr_2)
	{
		checked
		{
			if (int_6 == 0)
			{
				Struct0 @struct = default(Struct0);
				Struct0 struct2 = default(Struct0);
				if (!(intptr_1 == (IntPtr)256) && !(intptr_1 == (IntPtr)260))
				{
					if (intptr_1 == (IntPtr)257 || intptr_1 == (IntPtr)261)
					{
						Delegate1 @delegate = delegate1_0;
						if (@delegate != null)
						{
							object? obj = Marshal.PtrToStructure(intptr_2, @struct.GetType());
							@delegate((Keys)(int)((obj != null) ? ((Struct0)obj) : struct2).uint_0);
						}
					}
				}
				else
				{
					Delegate0 delegate2 = delegate0_0;
					if (delegate2 != null)
					{
						object? obj2 = Marshal.PtrToStructure(intptr_2, @struct.GetType());
						delegate2((Keys)(int)((obj2 != null) ? ((Struct0)obj2) : struct2).uint_0);
					}
				}
			}
			return CallNextHookEx((int)IntPtr.Zero, int_6, intptr_1, intptr_2);
		}
	}

	public Class6()
	{
		delegate2_0 = method_0;
		intptr_0 = IntPtr.Zero;
		intptr_0 = (IntPtr)SetWindowsHookEx(13, delegate2_0, (IntPtr)Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
		if (intptr_0 == IntPtr.Zero)
		{
			throw new Exception("Could not set keyboard hook");
		}
	}

	protected override void Finalize()
	{
		if (!(intptr_0 == IntPtr.Zero))
		{
			UnhookWindowsHookEx((int)intptr_0);
		}
		base.Finalize();
	}
}
