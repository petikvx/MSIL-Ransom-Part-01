using System.Diagnostics;

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
			//Discarded unreachable code: IL_0008, IL_0009
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			_ = (short)/*Error near IL_0001: ldarg 1 (out-of-bounds)*/;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	[Conditional("DEBUG")]
	private extern void method_0(bool bool_1);

	internal extern Struct1(int int_2);

	internal Struct1(Struct0 struct0_0, ref int int_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*/>> (int)/*Error near IL_0001: Stack underflow*/;
		throw checked((nint)/*Error near IL_0001: ldarg 3 (out-of-bounds)*/);
	}

	internal Struct0 method_1(int int_2)
	{
		/*Error: Invalid metadata token*/;
	}

	private extern void method_2(int int_2, out int int_3, out uint[] uint_2);

	private extern void method_3(uint uint_2);

	private extern void method_4(ulong ulong_0);

	private extern void method_5();

	private extern void method_6(int int_2);

	private extern void method_7(int int_2);

	private extern void method_8(int int_2, int int_3);

	private extern void method_9(int int_2 = 0);

	private extern void method_10(ref Struct1 struct1_0, int int_2);

	private extern void method_11(uint uint_2);

	internal extern void method_12(ref Struct1 struct1_0, ref Struct1 struct1_1);

	private static uint smethod_0(ref Struct1 struct1_0, uint uint_2)
	{
		//Discarded unreachable code: IL_000e
		//IL_0009: Incompatible stack heights: 0 vs 2
		while (true)
		{
			_ = (nuint)unchecked((nint)(-2.1993866E+12f));
			/*Error near IL_0008: ldarg 2 (out-of-bounds)*/;
		}
	}

	internal extern void method_13(ref Struct1 struct1_0);

	private static extern void smethod_1(ref Struct1 struct1_0, ref Struct1 struct1_1, bool bool_1, ref Struct1 struct1_2);

	private static extern uint smethod_2(ref uint uint_2, uint uint_3, uint uint_4);

	private static extern uint smethod_3(ref uint uint_2, uint uint_3, uint uint_4);

	private static extern uint smethod_4(ref uint uint_2, uint uint_3, uint uint_4, uint uint_5);
}
