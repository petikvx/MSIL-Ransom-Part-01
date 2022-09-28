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

	public void method_0()
	{
		//Discarded unreachable code: IL_0017, IL_001c, IL_0020, IL_0027, IL_002d, IL_0034
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		while ((int)/*Error near IL_0006: Stack underflow*/ != 0 || /*Error near IL_000d: Stack underflow*/> /*Error near IL_000d: Stack underflow*/|| /*Error near IL_0012: Stack underflow*/< /*Error near IL_0012: Stack underflow*/)
		{
		}
		/*Error near IL_0012: Invalid metadata token*/;
	}

	public unsafe IntPtr method_1(GDelegate0 gdelegate0_1)
	{
		//Discarded unreachable code: IL_0018, IL_0020, IL_002c
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_000e: Incompatible stack heights: 2 vs 0
		//IL_0012: Expected I, but got O
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I8, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I8, but got F8
		int num = (int)/*Error near IL_0001: Stack underflow*/;
		object obj = ((object[])8)[1.4276308424732219E-77];
		while (num + obj > 0)
		{
		}
		*(IntPtr*)num = (IntPtr)obj;
		((sbyte[])/*Error near IL_0013: Stack underflow*/)[/*Error near IL_0013: Stack underflow*/] = (sbyte)/*Error near IL_0013: Stack underflow*/;
		/*Error near IL_0013: Invalid metadata token*/;
	}

	public static extern IntPtr smethod_0(int int_2, IntPtr intptr_1, IntPtr intptr_2);

	public static extern string smethod_1();

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

	public unsafe GClass1()
	{
		//Discarded unreachable code: IL_000c
		//IL_0003: Expected F8, but got O
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		*(double*)(int)(byte)/*Error near IL_0001: Stack underflow*/ = (double)this;
		_ = /*Error near IL_0005: Stack underflow*/& /*Error near IL_0005: Stack underflow*/;
		_ = 1;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern ApplicationContext smethod_2();

	static extern void smethod_3(ApplicationContext applicationContext_0);

	static Process smethod_4()
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0013, IL_0021, IL_0027, IL_002c, IL_0032, IL_0033, IL_0037, IL_003e
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected I4, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_0032: Incompatible stack heights: 0 vs 1
		//IL_0039: Invalid comparison between I8 and Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static ProcessModule smethod_5(Process process_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*/^ /*Error near IL_0001: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	unsafe static string smethod_6(ProcessModule processModule_0)
	{
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0009: Expected F4, but got I4
		byte num;
		do
		{
			num = *(byte*)(nint)/*Error: ldloc 1 (out-of-bounds)*/;
		}
		while ((int)/*Error near IL_0007: Stack underflow*/ > (int)num);
		byte num2 = *(byte*)(nint)/*Error near IL_0008: Stack underflow*/;
		((float[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (int)num2;
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_7(IDisposable idisposable_0);

	unsafe static int smethod_8(IntPtr intptr_1)
	{
		//Discarded unreachable code: IL_0011
		//IL_000d: Expected O, but got I8
		//IL_0016: Invalid comparison between Unknown and I4
		_ = *(uint*)(nint)/*Error near IL_0001: Stack underflow*/;
		_ = 4294967199L;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	static extern Encoding smethod_9();

	static byte[] smethod_10(Encoding encoding_0, string string_1)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0016, IL_001d, IL_0023
		_ = -746779255;
		/*Error near IL_0005: Unknown opcode: 0xFA*/;
	}

	static StringBuilder smethod_11(int int_2)
	{
		//Discarded unreachable code: IL_0009, IL_000f
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		short num = checked((short)/*Error near IL_0001: Stack underflow*/);
		_ = (short)checked((ulong)unchecked(/*Error near IL_0002: Stack underflow*/ / num));
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static extern string smethod_12(object object_0);
}
