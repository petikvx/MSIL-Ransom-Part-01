using System;
using System.Diagnostics;

internal struct Struct1
{
	private const int int_0 = 32;

	private int int_1;

	private uint uint_0;

	private uint[] uint_1;

	private bool bool_0;

	internal unsafe int Int32_0
	{
		get
		{
			_ = *(uint*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
			throw /*Error near IL_0003: Stack underflow*/;
		}
	}

	private int Int32_1
	{
		get
		{
			//Discarded unreachable code: IL_0007, IL_0009, IL_000f, IL_0014, IL_0015
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	[Conditional("DEBUG")]
	private extern void method_0(bool bool_1);

	internal extern Struct1(int int_2);

	internal extern Struct1(Struct0 struct0_0, ref int int_2);

	internal extern Struct0 method_1(int int_2);

	private extern void method_2(int int_2, out int int_3, out uint[] uint_2);

	private extern void method_3(uint uint_2);

	private void method_4(ulong ulong_0)
	{
	}

	private extern void method_5();

	private extern void method_6(int int_2);

	private extern void method_7(int int_2);

	private extern void method_8(int int_2, int int_3);

	private unsafe void method_9(int int_2 = 0)
	{
		//IL_0003: Invalid comparison between Unknown and I4
		byte num;
		do
		{
			num = ((byte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*OpCode not supported: DebugBreak*/;
		}
		while ((int)/*Error near IL_0008: Stack underflow*/ <= (int)num);
		_ = 1;
		/*Error near IL_000a: stloc 0 (out-of-bounds)*/;
		switch (*(ushort*)(nint)/*Error near IL_000c: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	private void method_10(ref Struct1 struct1_0, int int_2)
	{
		//Discarded unreachable code: IL_000f, IL_0014, IL_001c, IL_0025, IL_002a, IL_003b, IL_0040, IL_0046, IL_004d, IL_0052, IL_0058, IL_0063, IL_006d, IL_006f, IL_0071, IL_0077, IL_0081, IL_0086, IL_008f, IL_0095, IL_009b, IL_00a4, IL_00ab, IL_00ba, IL_00c0
		//IL_0001: Unsupported input type for neg.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected O, but got I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected I4, but got F8
		//IL_003e: Invalid comparison between Unknown and I
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected F4, but got O
		//IL_0061: Invalid comparison between Unknown and F8
		//IL_0068: Invalid comparison between Unknown and I8
		//IL_007a: Expected O, but got I4
		//IL_007f: Incompatible stack heights: 0 vs 1
		//IL_0084: Incompatible stack heights: 0 vs 2
		//IL_008a: Incompatible stack heights: 0 vs 1
		//IL_0095: Unsupported input type for neg.
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected I4, but got Unknown
		//IL_009f: Incompatible stack heights: 0 vs 1
		_003F val = /*Error: Stack underflow*/;
		IntPtr intPtr = (nint)((Array)((ushort[])/*Error near IL_0003: Stack underflow*/)[0 - val]).LongLength;
		/*OpCode not supported: DebugBreak*/;
		object obj = ((object[])/*Error near IL_0006: Stack underflow*/)[(nint)intPtr];
		/*OpCode not supported: DebugBreak*/;
		_ = ((ushort[])/*Error near IL_0009: Stack underflow*/)[obj];
		_ = 8;
		/*Error near IL_000a: Invalid metadata token*/;
	}

	private extern void method_11(uint uint_2);

	internal void method_12(ref Struct1 struct1_0, ref Struct1 struct1_1)
	{
		switch (/*Error near IL_0005: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	private static extern uint smethod_0(ref Struct1 struct1_0, uint uint_2);

	internal extern void method_13(ref Struct1 struct1_0);

	private static extern void smethod_1(ref Struct1 struct1_0, ref Struct1 struct1_1, bool bool_1, ref Struct1 struct1_2);

	private static extern uint smethod_2(ref uint uint_2, uint uint_3, uint uint_4);

	private static extern uint smethod_3(ref uint uint_2, uint uint_3, uint uint_4);

	private static uint smethod_4(ref uint uint_2, uint uint_3, uint uint_4, uint uint_5)
	{
		checked
		{
			_ = (byte)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}
}
