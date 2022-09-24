using System.Diagnostics;
using System.Runtime.CompilerServices;

internal struct Struct1
{
	private const int int_0 = 32;

	private int int_1;

	private uint uint_0;

	private uint[] uint_1;

	private bool bool_0;

	internal extern int Int32_0 { get; }

	private int Int32_1
	{
		get
		{
			throw /*Error near IL_0001: Stack underflow*/;
		}
	}

	[Conditional("DEBUG")]
	private extern void method_0(bool bool_1);

	internal extern Struct1(int int_2);

	internal extern Struct1(Struct0 struct0_0, ref int int_2);

	internal extern Struct0 method_1(int int_2);

	private extern void method_2(int int_2, out int int_3, out uint[] uint_2);

	private extern void method_3(uint uint_2);

	private extern void method_4(ulong ulong_0);

	private extern void method_5();

	private unsafe void method_6(int int_2)
	{
		//IL_0002: Invalid comparison between Unknown and Ref
		//IL_000a: Expected F8, but got Unknown
		while (!System.Runtime.CompilerServices.Unsafe.IsAddressGreaterThan(ref *(byte*)/*Error near IL_0007: Stack underflow*/, ref System.Runtime.CompilerServices.Unsafe.As<Struct1, byte>(ref this)))
		{
		}
		_003F val = /*Error near IL_0008: ldloc 3 (out-of-bounds)*/;
		((double[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/] = (double)val;
		*(_003F*)(nint)/*Error near IL_000b: Stack underflow*/ = /*Error near IL_000b: Stack underflow*/;
		double num = (double)/*Error near IL_000c: Stack underflow*/;
		checked
		{
			_ = (nint)((float[])/*Error near IL_000d: Stack underflow*/)[num];
			/*Error near IL_000f: stloc 0 (out-of-bounds)*/;
			/*OpCode not supported: Ckfinite*/;
			/*Error near IL_0012: ldloc 1 (out-of-bounds)*/;
			/*Error: Unexpected end of block*/;
		}
	}

	private extern void method_7(int int_2);

	private unsafe void method_8(int int_2, int int_3)
	{
		//Discarded unreachable code: IL_0022, IL_002a, IL_002d, IL_0030
		//IL_0001: Invalid comparison between Unknown and I4
		//IL_0010: Invalid comparison between F8 and Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_002f: Incompatible stack heights: 0 vs 1
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			byte num = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
			if ((int)/*Error near IL_0006: Stack underflow*/ != num && !(-5.788349206784311E-171 > (double)/*Error near IL_000f: ldloc 1 (out-of-bounds)*/))
			{
				_003F val = /*Error near IL_0017: Stack underflow*/& /*Error near IL_0017: Stack underflow*/;
				if (/*Error near IL_001c: Stack underflow*/ < val)
				{
					break;
				}
			}
		}
		uint num2 = checked((uint)/*Error near IL_001d: Stack underflow*/);
		((int[])/*Error near IL_001e: Stack underflow*/)[/*Error near IL_001e: Stack underflow*/] = (int)num2;
		byte num3 = *(byte*)checked((nuint)/*Error near IL_001f: Stack underflow*/);
		_ = /*Error near IL_0021: Stack underflow*/& num3;
		/*Error near IL_0021: Unknown opcode: 0xFA*/;
	}

	private extern void method_9(int int_2 = 0);

	private void method_10(ref Struct1 struct1_0, int int_2)
	{
		//Discarded unreachable code: IL_000c, IL_0010
		_003F val = /*Error: ldloc 2 (out-of-bounds)*/;
		_ = ((sbyte[])/*Error near IL_0004: Stack underflow*/)[(long)val];
		_ = 2;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	private extern void method_11(uint uint_2);

	internal extern void method_12(ref Struct1 struct1_0, ref Struct1 struct1_1);

	private unsafe static uint smethod_0(ref Struct1 struct1_0, uint uint_2)
	{
		//IL_0004: Expected O, but got F8
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			int num = *(int*)(nint)/*Error near IL_0001: Stack underflow*/;
			((object[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (double)(uint)num;
			val = checked(/*Error near IL_0005: Stack underflow*/ - /*Error near IL_0005: Stack underflow*/);
		}
		while (/*Error near IL_000a: Stack underflow*/ >= val || /*Error near IL_000f: Stack underflow*/<= /*Error near IL_000f: Stack underflow*/);
		checked
		{
			_ = /*Error near IL_0010: Stack underflow*/* /*Error near IL_0010: Stack underflow*/;
			_ = -2.6017005E+19f;
			/*Error: Unexpected end of block*/;
		}
	}

	internal void method_13(ref Struct1 struct1_0)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: stloc 1 (out-of-bounds)*/;
		ulong num = (ulong)/*Error near IL_0003: Stack underflow*/;
		long num2 = ((long[])/*Error near IL_0005: Stack underflow*/)[num];
		checked
		{
			_ = /*Error near IL_0006: Stack underflow*/- num2;
			/*Error: Unexpected end of block*/;
		}
	}

	private static extern void smethod_1(ref Struct1 struct1_0, ref Struct1 struct1_1, bool bool_1, ref Struct1 struct1_2);

	private static extern uint smethod_2(ref uint uint_2, uint uint_3, uint uint_4);

	private static extern uint smethod_3(ref uint uint_2, uint uint_3, uint uint_4);

	private static extern uint smethod_4(ref uint uint_2, uint uint_3, uint uint_4, uint uint_5);
}
