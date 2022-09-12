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

	internal int Int32_1
	{
		get
		{
			/*Error: Unexpected end of block*/;
		}
	}

	internal extern uint[] UInt32_0 { get; }

	[Conditional("DEBUG")]
	private extern void method_0();

	public override bool E93CCE92(object object_0)
	{
		/*Error: Invalid metadata token*/;
	}

	public override extern int vmethod_0();

	private extern int method_1(Struct0 struct0_4);

	internal byte[] method_2()
	{
		/*Error near IL_0006: ldloc 2 (out-of-bounds)*/;
		/*Error near IL_0007: ldarg 1 (out-of-bounds)*/;
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
	public static extern bool smethod_6(Struct0 struct0_4, Struct0 struct0_5);

	[SpecialName]
	public static extern bool smethod_7(Struct0 struct0_4, Struct0 struct0_5);

	[SpecialName]
	public static extern bool smethod_8(Struct0 struct0_4, Struct0 struct0_5);

	[SpecialName]
	public static extern bool smethod_9(Struct0 struct0_4, Struct0 struct0_5);

	[SpecialName]
	public static extern bool smethod_10(Struct0 struct0_4, Struct0 struct0_5);

	private static extern int smethod_11(uint[] uint_2);

	private static extern int smethod_12(uint[] uint_2, uint[] uint_3, int int_2);
}
