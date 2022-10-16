using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[Serializable]
internal struct Struct0
{
	private const uint uint_0 = 2147483648u;

	private const int int_0 = 32;

	private readonly int int_1;

	private readonly uint[] uint_1;

	private static readonly Struct0 struct0_0;

	private static readonly Struct0 struct0_1;

	private static readonly Struct0 struct0_2;

	private static readonly Struct0 struct0_3;

	private static extern Struct0 Struct0_0 { get; }

	private extern bool Boolean_0 { get; }

	private extern int Int32_0 { get; }

	internal extern int Int32_1 { get; }

	internal extern uint[] UInt32_0 { get; }

	[Conditional("DEBUG")]
	private extern void method_0();

	public override extern bool vmethod_0(object object_0);

	public override extern int vmethod_1();

	private extern int method_1(Struct0 struct0_4);

	internal byte[] method_2()
	{
		while ("" == null)
		{
		}
		/*OpCode not supported: DebugBreak*/;
		/*Error: Unexpected end of block*/;
	}

	private extern Struct0(int int_2);

	internal extern Struct0(byte[] byte_0);

	internal extern Struct0(int int_2, uint[] uint_2);

	private static extern void smethod_0(ref Struct1 struct1_0, ref Struct1 struct1_1, ref Struct1 struct1_2, ref Struct1 struct1_3);

	private static extern void smethod_1(ref Struct1 struct1_0, ref Struct1 struct1_1, ref Struct1 struct1_2);

	private static extern void smethod_2(uint uint_2, ref Struct1 struct1_0, ref Struct1 struct1_1, ref Struct1 struct1_2, ref Struct1 struct1_3);

	private static extern void smethod_3(uint uint_2, ref Struct1 struct1_0, ref Struct1 struct1_1, ref Struct1 struct1_2, ref Struct1 struct1_3);

	internal static extern Struct0 smethod_4(Struct0 struct0_4, Struct0 struct0_5, Struct0 struct0_6);

	[SpecialName]
	public static extern bool smethod_5(Struct0 struct0_4, Struct0 struct0_5);

	[SpecialName]
	public static bool smethod_6(Struct0 struct0_4, Struct0 struct0_5)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected I4, but got Unknown
		double num = (double)/*Error near IL_0003: Stack underflow*/;
		_ = /*Error near IL_0004: Stack underflow*/>> (int)num;
		checked
		{
			_ = (nint)/*Error near IL_0004: ldarg 3 (out-of-bounds)*/;
		}
		_003F val = /*Error near IL_0006: ldloc 0 (out-of-bounds)*/>> (int)struct0_5;
		/*OpCode not supported: DebugBreak*/;
		return (byte)(int)val != 0;
	}

	[SpecialName]
	public unsafe static bool smethod_7(Struct0 struct0_4, Struct0 struct0_5)
	{
		//Discarded unreachable code: IL_0009, IL_000f, IL_0018, IL_001e, IL_0028, IL_002e
		//IL_0001: Unsupported input type for neg.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected native int or pointer, but got O
		//IL_0019: Incompatible stack heights: 0 vs 1
		//IL_0023: Incompatible stack heights: 0 vs 1
		_003F val = 0 - /*Error near IL_0002: Stack underflow*/;
		_ = /*Error near IL_0003: Stack underflow*/>> (int)val;
		_ = *(uint*)(nint)/*Error near IL_0003: ldarg 3 (out-of-bounds)*/;
		/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0008: Unknown opcode: 0xF8*/;
	}

	[SpecialName]
	public static extern bool smethod_8(Struct0 struct0_4, Struct0 struct0_5);

	[SpecialName]
	public static extern bool smethod_9(Struct0 struct0_4, Struct0 struct0_5);

	[SpecialName]
	public static extern bool smethod_10(Struct0 struct0_4, Struct0 struct0_5);

	private static int smethod_11(uint[] uint_2)
	{
		_003F val = /*Error: ldarg 1 (out-of-bounds)*/;
		if (/*Error near IL_0003: Stack underflow*/ > val)
		{
		}
		/*Error near IL_0003: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	private static extern int smethod_12(uint[] uint_2, uint[] uint_3, int int_2);

	static Struct0()
	{
		//Discarded unreachable code: IL_000d
		//IL_0002: Invalid comparison between Unknown and I
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		nuint num = checked((nuint)/*Error: ldarg 1 (out-of-bounds)*/);
		if ((nint)/*Error near IL_0004: Stack underflow*/ < (nint)num)
		{
		}
		if (/*Error near IL_0006: Stack underflow*/ < /*Error near IL_0006: Stack underflow*/)
		{
			_ = 5;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0008: Invalid metadata token*/;
		}
		_ = /*Error near IL_0014: Stack underflow*/>> (int)/*Error near IL_0014: Stack underflow*/;
		/*OpCode not supported: DebugBreak*/;
	}
}
