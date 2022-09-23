using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[Serializable]
internal struct Struct1
{
	private const uint uint_0 = 2147483648u;

	private const int int_0 = 32;

	private readonly int int_1;

	private readonly uint[] uint_1;

	private static readonly Struct1 struct1_0;

	private static readonly Struct1 struct1_1;

	private static readonly Struct1 struct1_2;

	private static readonly Struct1 struct1_3;

	private static extern Struct1 Struct1_0 { get; }

	private extern bool Boolean_0 { get; }

	private extern int Int32_0 { get; }

	internal int Int32_1
	{
		get
		{
			//Discarded unreachable code: IL_0005, IL_0017, IL_001c
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected I, but got Unknown
			/*Error: Invalid metadata token*/;
		}
	}

	internal extern uint[] UInt32_0 { get; }

	[Conditional("DEBUG")]
	private extern void method_0();

	public override extern bool C0D4B14E(object object_0);

	public override extern int vmethod_0();

	private extern int method_1(Struct1 struct1_4);

	internal extern byte[] method_2();

	private extern Struct1(int int_2);

	internal extern Struct1(byte[] byte_0);

	internal extern Struct1(int int_2, uint[] uint_2);

	private static extern void smethod_0(ref Struct2 struct2_0, ref Struct2 struct2_1, ref Struct2 struct2_2, ref Struct2 struct2_3);

	private unsafe static void smethod_1(ref Struct2 struct2_0, ref Struct2 struct2_1, ref Struct2 struct2_2)
	{
		//Discarded unreachable code: IL_0009, IL_000f, IL_0021, IL_0024
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_ = *(int*)(nint)/*Error near IL_0001: Stack underflow*/;
		_ = /*Error near IL_0002: ldloc 0 (out-of-bounds)*/- /*Error near IL_0003: ldloc 2 (out-of-bounds)*/;
		_ = (double)/*Error near IL_0005: ldarg 3 (out-of-bounds)*/;
		/*Error near IL_0007: ldarg 3 (out-of-bounds)*/;
		/*Error near IL_0008: Unknown opcode: 0xFD*/;
	}

	private static extern void smethod_2(uint uint_2, ref Struct2 struct2_0, ref Struct2 struct2_1, ref Struct2 struct2_2, ref Struct2 struct2_3);

	private static extern void smethod_3(uint uint_2, ref Struct2 struct2_0, ref Struct2 struct2_1, ref Struct2 struct2_2, ref Struct2 struct2_3);

	internal static extern Struct1 smethod_4(Struct1 struct1_4, Struct1 struct1_5, Struct1 struct1_6);

	[SpecialName]
	public static extern bool smethod_5(Struct1 struct1_4, Struct1 struct1_5);

	[SpecialName]
	public static extern bool smethod_6(Struct1 struct1_4, Struct1 struct1_5);

	[SpecialName]
	public static extern bool smethod_7(Struct1 struct1_4, Struct1 struct1_5);

	[SpecialName]
	public static extern bool smethod_8(Struct1 struct1_4, Struct1 struct1_5);

	[SpecialName]
	public static bool smethod_9(Struct1 struct1_4, Struct1 struct1_5)
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	[SpecialName]
	public static extern bool smethod_10(Struct1 struct1_4, Struct1 struct1_5);

	private static extern int smethod_11(uint[] uint_2);

	private static int smethod_12(uint[] uint_2, uint[] uint_3, int int_2)
	{
		//Discarded unreachable code: IL_0010
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected I, but got Unknown
		do
		{
			/*Error: stloc 2 (out-of-bounds)*/;
		}
		while (/*Error near IL_0002: Stack underflow*/ + /*Error near IL_0002: Stack underflow*/> 2);
		_003F val = /*Error near IL_000a: Stack underflow*/^ /*Error near IL_000a: Stack underflow*/;
		((IntPtr[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = (IntPtr)val;
		/*Error near IL_000b: Invalid metadata token*/;
	}
}
