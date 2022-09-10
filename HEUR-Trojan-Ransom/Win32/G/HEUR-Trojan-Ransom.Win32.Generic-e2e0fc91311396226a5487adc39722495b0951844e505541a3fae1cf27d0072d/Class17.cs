using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

internal sealed class Class17
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 36)]
	private struct Struct20
	{
	}

	private static readonly object object_0;

	private static readonly object object_1;

	private static readonly object object_2;

	internal static Struct20 struct20_0/* Not supported: data(C7 82 AA 12 E7 DE 57 85 6E C4 34 66 FE A5 FC 31 6A C6 07 53 80 7F 30 77 C5 A6 9C 05 9C 94 FC BE 49 69 0F F5) */;

	public static extern void smethod_0(AppDomain appDomain_0);

	public extern Class17();

	internal static string smethod_1(int int_0, Class17 class17_0, Assembly assembly_0, int int_1)
	{
		throw /*Error near IL_0001: Stack underflow*/;
	}

	static extern Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0);

	unsafe static InvalidOperationException smethod_3()
	{
		*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
		checked
		{
			_ = (int)/*Error near IL_0003: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}

	static extern object smethod_4(AppDomain appDomain_0, string string_0, string string_1);

	static extern string smethod_5(Exception exception_0);

	static extern void smethod_6(string string_0);

	static extern StringBuilder smethod_7();

	static extern StringBuilder smethod_8(StringBuilder stringBuilder_0, char char_0);

	unsafe static string smethod_9(object object_3)
	{
		//Discarded unreachable code: IL_0007, IL_000c
		//IL_0001: Expected native int or pointer, but got O
		//IL_000b: Expected F4, but got I4
		//IL_0012: Expected I4, but got O
		_ = *(float*)(nint)((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0002: Invalid metadata token*/;
	}

	unsafe static void smethod_10(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Ref
		do
		{
			_003F val = /*Error near IL_0001: Stack underflow*/& /*Error near IL_0001: Stack underflow*/;
			_003F val2 = /*Error near IL_0002: Stack underflow*/>> (int)val;
			_003F val3 = /*Error near IL_0004: Stack underflow*/* val2;
			_003F val4 = /*Error near IL_0005: Stack underflow*/>> (int)val3;
			checked
			{
				_ = (double)(short)unchecked((int)((uint[])/*Error near IL_0006: Stack underflow*/)[val4]);
				/*Error near IL_0008: stloc 3 (out-of-bounds)*/;
			}
		}
		while ((nint)(*(IntPtr*)(nint)/*Error near IL_000a: Stack underflow*/) <= (nint)((Array)(&array_0)).LongLength);
		((float[])/*Error near IL_0014: Stack underflow*/)[/*Error near IL_0014: Stack underflow*/] = (float)/*Error near IL_0014: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}
}
