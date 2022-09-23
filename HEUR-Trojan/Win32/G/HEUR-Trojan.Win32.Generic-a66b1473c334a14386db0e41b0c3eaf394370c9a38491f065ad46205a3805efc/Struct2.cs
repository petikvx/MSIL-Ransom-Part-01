using System.Diagnostics;

internal struct Struct2
{
	private const int int_0 = 32;

	private int int_1;

	private uint uint_0;

	private uint[] uint_1;

	private bool bool_0;

	internal int Int32_0
	{
		get
		{
			//Discarded unreachable code: IL_0007, IL_0009, IL_000e, IL_0015
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				/*OpCode not supported: DebugBreak*/;
			}
		}
	}

	private int Int32_1
	{
		get
		{
			//Discarded unreachable code: IL_0001, IL_0008
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Invalid comparison between Unknown and I4
			/*Error: Unknown opcode: 0xFD*/;
		}
	}

	[Conditional("DEBUG")]
	private extern void method_0(bool bool_1);

	internal extern Struct2(int int_2);

	internal extern Struct2(Struct1 struct1_0, ref int int_2);

	internal extern Struct1 method_1(int int_2);

	private extern void method_2(int int_2, out int int_3, out uint[] uint_2);

	private extern void method_3(uint uint_2);

	private extern void method_4(ulong ulong_0);

	private extern void method_5();

	private extern void method_6(int int_2);

	private extern void method_7(int int_2);

	private extern void method_8(int int_2, int int_3);

	private extern void method_9(int int_2 = 0);

	private extern void method_10(ref Struct2 struct2_0, int int_2);

	private extern void method_11(uint uint_2);

	internal extern void method_12(ref Struct2 struct2_0, ref Struct2 struct2_1);

	private static extern uint smethod_0(ref Struct2 struct2_0, uint uint_2);

	internal extern void method_13(ref Struct2 struct2_0);

	private static extern void smethod_1(ref Struct2 struct2_0, ref Struct2 struct2_1, bool bool_1, ref Struct2 struct2_2);

	private static extern uint smethod_2(ref uint uint_2, uint uint_3, uint uint_4);

	private unsafe static uint smethod_3(ref uint uint_2, uint uint_3, uint uint_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		//IL_0010: Expected I4, but got O
		_003F val = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		((short[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (short)(int)val;
		uint_2 = ref *(uint*)uint_4;
		_ = *(byte*)(nint)/*Error near IL_0006: Stack underflow*/;
		switch ((int)"礀稀ⴀ\0愩挀琀椀瘀愀琀椀漀渀⸀瀀栀瀀㼀挀漀搀攀㴀\0琫礀瀀攀㴀愀挀琀椀瘀愀琀椀漀渀☀挀漀搀攀㴀\0☍栀眀椀搀㴀\0☍栀愀猀栀㴀")
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	private static extern uint smethod_4(ref uint uint_2, uint uint_3, uint uint_4, uint uint_5);
}
