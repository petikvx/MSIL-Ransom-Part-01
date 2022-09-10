using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

internal struct Struct2
{
	private const int int_0 = 32;

	private int int_1;

	private uint uint_0;

	private uint[] uint_1;

	private bool bool_0;

	internal extern int Int32_0 { get; }

	private extern int Int32_1 { get; }

	[Conditional("DEBUG")]
	private void method_0(bool bool_1)
	{
		//Discarded unreachable code: IL_0006
		((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (double)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	internal extern Struct2(int int_2);

	internal extern Struct2(Struct1 struct1_0, ref int int_2);

	internal unsafe Struct1 method_1(int int_2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		ushort num = (ushort)/*Error near IL_0001: Stack underflow*/;
		*(IntPtr*)(nint)/*Error near IL_0004: Stack underflow*/ = (IntPtr)(int)num;
		*(_003F*)(nint)/*Error near IL_0005: Stack underflow*/ = /*Error near IL_0005: Stack underflow*/;
		_003F val = checked(/*Error near IL_0006: Stack underflow*/ + /*Error near IL_0006: Stack underflow*/);
		short num2 = ((short[])/*Error near IL_0007: Stack underflow*/)[val];
		*(int*)(nint)/*Error near IL_0009: Stack underflow*/ = num2;
		throw /*Error near IL_000a: Stack underflow*/;
	}

	private void method_2(int int_2, out int int_3, out uint[] uint_2)
	{
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private extern void method_3(uint uint_2);

	private void method_4(ulong ulong_0)
	{
		_ = 0;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private extern void method_5();

	private void method_6(int int_2)
	{
		//Discarded unreachable code: IL_000d, IL_0014, IL_0019, IL_0028, IL_002e, IL_0034, IL_003c, IL_003d
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
		}
		_ = 7;
		_ = 4;
		_ = 2;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	private extern void method_7(int int_2);

	private extern void method_8(int int_2, int int_3);

	private extern void method_9([Optional] int int_2);

	private unsafe void method_10(ref Struct2 struct2_0, int int_2)
	{
		//Discarded unreachable code: IL_0011, IL_0016
		//IL_0002: Invalid comparison between Unknown and I4
		byte num;
		do
		{
			checked
			{
				num = (byte)(*unchecked((uint*)(nint)/*Error near IL_0001: Stack underflow*/));
			}
		}
		while ((int)/*Error near IL_0007: Stack underflow*/ < (int)num);
		_ = (int)/*Error near IL_0008: Stack underflow*/;
		_ = 8;
		_ = 8;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	private extern void method_11(uint uint_2);

	internal extern void method_12(ref Struct2 struct2_0, ref Struct2 struct2_1);

	private static extern uint smethod_0(ref Struct2 struct2_0, uint uint_2);

	internal extern void method_13(ref Struct2 struct2_0);

	private static void smethod_1(ref Struct2 struct2_0, ref Struct2 struct2_1, bool bool_1, ref Struct2 struct2_2)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0010, IL_0015, IL_001a, IL_001f, IL_0028
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected F8, but got Unknown
		//IL_0023: Invalid comparison between Unknown and I4
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private static uint smethod_2(ref uint uint_2, uint uint_3, uint uint_4)
	{
		//Discarded unreachable code: IL_0005, IL_000d, IL_0014, IL_0019
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got I8
		/*Error: Invalid metadata token*/;
	}

	private static uint smethod_3(ref uint uint_2, uint uint_3, uint uint_4)
	{
		//Discarded unreachable code: IL_0005, IL_000e, IL_0015, IL_001b
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and F8
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	private unsafe static uint smethod_4(ref uint uint_2, uint uint_3, uint uint_4, uint uint_5)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F8, but got Unknown
		//IL_0012: Invalid comparison between Unknown and I4
		while (true)
		{
			int num = *(int*)(int)((ushort[])(double)/*Error near IL_0001: Stack underflow*/)[2];
			_003F val = /*Error near IL_0007: Stack underflow*// num;
			((double[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (double)val;
			if (/*Error near IL_000f: Stack underflow*/ > /*Error near IL_000f: Stack underflow*/)
			{
				sbyte num2;
				checked
				{
					num2 = (sbyte)unchecked((uint)(*(short*)(nint)/*Error near IL_0011: Stack underflow*/));
				}
				if ((int)/*Error near IL_0017: Stack underflow*/ > (int)num2 && /*Error near IL_001c: Stack underflow*/!= /*Error near IL_001c: Stack underflow*/)
				{
					break;
				}
			}
		}
		checked
		{
			_ = (byte)/*Error near IL_001d: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}
}
