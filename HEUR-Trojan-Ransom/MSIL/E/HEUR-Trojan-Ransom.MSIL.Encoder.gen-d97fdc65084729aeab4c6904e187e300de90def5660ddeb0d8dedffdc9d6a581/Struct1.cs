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

	internal unsafe int Int32_1
	{
		get
		{
			do
			{
				checked
				{
					_ = (byte)/*Error near IL_0001: Stack underflow*/;
				}
			}
			while ((int)/*Error near IL_0009: Stack underflow*/ != 0);
			throw *(double*)(nint)/*Error near IL_000c: Stack underflow*/;
		}
	}

	internal extern uint[] UInt32_0 { get; }

	[Conditional("DEBUG")]
	private extern void method_0();

	public override extern bool F05D8872(object object_0);

	public override extern int vmethod_0();

	private int method_1(Struct1 struct1_4)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			while (true)
			{
				if (/*Error near IL_0008: Stack underflow*/ - unchecked((int)"") == 0)
				{
					/*Error: Could not find block for branch target IL_000e*/;
				}
			}
		}
	}

	internal extern byte[] method_2();

	private Struct1(int int_2)
	{
		//Discarded unreachable code: IL_000d, IL_0018, IL_002c, IL_0035, IL_003a
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected F8, but got I
		//IL_002d: Expected native int or pointer, but got F8
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_003b: Invalid comparison between Unknown and I8
		while (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0006: Stack underflow*/)
		{
		}
		_ = ((int[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/];
		/*Error near IL_0008: Invalid metadata token*/;
	}

	internal extern Struct1(byte[] byte_0);

	internal Struct1(int int_2, uint[] uint_2)
	{
		//Discarded unreachable code: IL_0006
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	private unsafe static void smethod_0(ref Struct2 struct2_0, ref Struct2 struct2_1, ref Struct2 struct2_2, ref Struct2 struct2_3)
	{
		//Discarded unreachable code: IL_000e, IL_0018, IL_001d, IL_0026, IL_002c, IL_0035
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Incompatible stack heights: 0 vs 1
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0005: Stack underflow*/ != /*Error near IL_0005: Stack underflow*/)
		{
			((short[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (short)System.Runtime.CompilerServices.Unsafe.AsPointer(ref struct2_3);
			/*Error near IL_0009: Invalid metadata token*/;
		}
		_ = (int)((uint[])/*Error near IL_003e: Stack underflow*/)[/*Error near IL_003e: Stack underflow*/];
	}

	private static extern void smethod_1(ref Struct2 struct2_0, ref Struct2 struct2_1, ref Struct2 struct2_2);

	private static extern void smethod_2(uint uint_2, ref Struct2 struct2_0, ref Struct2 struct2_1, ref Struct2 struct2_2, ref Struct2 struct2_3);

	private static extern void smethod_3(uint uint_2, ref Struct2 struct2_0, ref Struct2 struct2_1, ref Struct2 struct2_2, ref Struct2 struct2_3);

	internal static Struct1 smethod_4(Struct1 struct1_4, Struct1 struct1_5, Struct1 struct1_6)
	{
		byte num;
		do
		{
			num = checked((byte)/*Error near IL_0001: Stack underflow*/);
		}
		while ((int)((float[])/*Error near IL_0002: Stack underflow*/)[num] != 0);
		/*Error near IL_0007: Invalid metadata token*/;
	}

	[SpecialName]
	public static extern bool smethod_5(Struct1 struct1_4, Struct1 struct1_5);

	[SpecialName]
	public static extern bool smethod_6(Struct1 struct1_4, Struct1 struct1_5);

	[SpecialName]
	public static extern bool smethod_7(Struct1 struct1_4, Struct1 struct1_5);

	[SpecialName]
	public static extern bool smethod_8(Struct1 struct1_4, Struct1 struct1_5);

	[SpecialName]
	public static extern bool smethod_9(Struct1 struct1_4, Struct1 struct1_5);

	[SpecialName]
	public static bool smethod_10(Struct1 struct1_4, Struct1 struct1_5)
	{
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		_ = (byte)/*Error near IL_0006: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	private static extern int smethod_11(uint[] uint_2);

	private static extern int smethod_12(uint[] uint_2, uint[] uint_3, int int_2);

	static Struct1()
	{
		//Discarded unreachable code: IL_0002, IL_0007, IL_000c, IL_0014, IL_0020, IL_0028, IL_0032
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I8, but got I4
		//IL_0023: Invalid comparison between Unknown and I
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Unknown opcode: 0xF8*/;
	}
}
