using System.Diagnostics;

internal struct Struct1
{
	private const int int_0 = 32;

	private int int_1;

	private uint uint_0;

	private uint[] uint_1;

	private bool bool_0;

	internal extern int Int32_0 { get; }

	private extern int Int32_1 { get; }

	[Conditional("DEBUG")]
	private extern void method_0(bool bool_1);

	internal extern Struct1(int int_2);

	internal unsafe Struct1(Struct0 struct0_0, ref int int_2)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		uint num = *(uint*)(sbyte)int_2 << 8;
		/*OpCode not supported: DebugBreak*/;
		_ = /*Error near IL_0009: Stack underflow*/^ num;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	internal extern Struct0 method_1(int int_2);

	private extern void method_2(int int_2, out int int_3, out uint[] uint_2);

	private extern void method_3(uint uint_2);

	private extern void method_4(ulong ulong_0);

	private extern void method_5();

	private extern void method_6(int int_2);

	private void method_7(int int_2)
	{
		/*Error: stloc 0 (out-of-bounds)*/;
		_ = (nint)((float[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		/*Error near IL_0004: stloc 0 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	private extern void method_8(int int_2, int int_3);

	private extern void method_9(int int_2 = 0);

	private extern void method_10(ref Struct1 struct1_0, int int_2);

	private extern void method_11(uint uint_2);

	internal extern void method_12(ref Struct1 struct1_0, ref Struct1 struct1_1);

	private static uint smethod_0(ref Struct1 struct1_0, uint uint_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		while (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) == 0)
		{
		}
		/*OpCode not supported: DebugBreak*/;
		/*Error: Unexpected end of block*/;
	}

	internal extern void method_13(ref Struct1 struct1_0);

	private static void smethod_1(ref Struct1 struct1_0, ref Struct1 struct1_1, bool bool_1, ref Struct1 struct1_2)
	{
		_ = ((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*OpCode not supported: DebugBreak*/;
		_ = 8;
		/*Error near IL_0005: stloc 0 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	private static extern uint smethod_2(ref uint uint_2, uint uint_3, uint uint_4);

	private static extern uint smethod_3(ref uint uint_2, uint uint_3, uint uint_4);

	private static uint smethod_4(ref uint uint_2, uint uint_3, uint uint_4, uint uint_5)
	{
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}
}
