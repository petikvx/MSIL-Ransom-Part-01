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

	internal Struct1(int int_2)
	{
		while (true)
		{
			_ = 0 - (uint)(double)/*Error near IL_0002: Stack underflow*/;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0007: stloc 0 (out-of-bounds)*/;
			if (/*Error near IL_000d: Stack underflow*/ >= /*Error near IL_000d: Stack underflow*/)
			{
				/*Error: Could not find block for branch target IL_000d*/;
			}
		}
	}

	internal extern Struct1(Struct0 struct0_0, ref int int_2);

	internal extern Struct0 method_1(int int_2);

	private extern void method_2(int int_2, out int int_3, out uint[] uint_2);

	private extern void method_3(uint uint_2);

	private void method_4(ulong ulong_0)
	{
		/*Error: Unexpected end of block*/;
	}

	private extern void method_5();

	private extern void method_6(int int_2);

	private extern void method_7(int int_2);

	private extern void method_8(int int_2, int int_3);

	private void method_9(int int_2 = 0)
	{
		//Discarded unreachable code: IL_0007
		_ = (short)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private extern void method_10(ref Struct1 struct1_0, int int_2);

	private extern void method_11(uint uint_2);

	internal extern void method_12(ref Struct1 struct1_0, ref Struct1 struct1_1);

	private static extern uint smethod_0(ref Struct1 struct1_0, uint uint_2);

	internal extern void method_13(ref Struct1 struct1_0);

	private static void smethod_1(ref Struct1 struct1_0, ref Struct1 struct1_1, bool bool_1, ref Struct1 struct1_2)
	{
		//Discarded unreachable code: IL_0006, IL_000e, IL_0014, IL_0018, IL_001d, IL_0023
		//IL_0009: Invalid comparison between Unknown and I4
		checked
		{
			_ = (ushort)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	private unsafe static uint smethod_2(ref uint uint_2, uint uint_3, uint uint_4)
	{
		//Discarded unreachable code: IL_0011
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		int num;
		do
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			num = /*Error near IL_0002: Stack underflow*// /*Error near IL_0002: Stack underflow*/;
		}
		while ((int)/*Error near IL_0009: Stack underflow*/ < num);
		checked
		{
			_ = /*Error near IL_000c: Stack underflow*/- 11;
			/*Error near IL_000c: Invalid metadata token*/;
		}
	}

	private static extern uint smethod_3(ref uint uint_2, uint uint_3, uint uint_4);

	private static extern uint smethod_4(ref uint uint_2, uint uint_3, uint uint_4, uint uint_5);
}
