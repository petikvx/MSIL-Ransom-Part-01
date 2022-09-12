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

	internal extern Struct1(Struct0 struct0_0, ref int int_2);

	internal extern Struct0 method_1(int int_2);

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

	private static extern uint smethod_0(ref Struct1 struct1_0, uint uint_2);

	internal extern void method_13(ref Struct1 struct1_0);

	private static extern void smethod_1(ref Struct1 struct1_0, ref Struct1 struct1_1, bool bool_1, ref Struct1 struct1_2);

	private static extern uint smethod_2(ref uint uint_2, uint uint_3, uint uint_4);

	private static extern uint smethod_3(ref uint uint_2, uint uint_3, uint uint_4);

	private static extern uint smethod_4(ref uint uint_2, uint uint_3, uint uint_4, uint uint_5);
}
