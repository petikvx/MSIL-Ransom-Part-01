using System.Diagnostics;
using System.Runtime.CompilerServices;

internal struct Struct3
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
			/*Error: Invalid metadata token*/;
		}
	}

	private extern int Int32_1 { get; }

	[Conditional("DEBUG")]
	private extern void method_0(bool bool_1);

	internal extern Struct3(int int_2);

	internal extern Struct3(Struct2 struct2_0, ref int int_2);

	internal extern Struct2 method_1(int int_2);

	private extern void method_2(int int_2, out int int_3, out uint[] uint_2);

	private extern void method_3(uint uint_2);

	private extern void method_4(ulong ulong_0);

	private extern void method_5();

	private extern void method_6(int int_2);

	private void method_7(int int_2)
	{
		//Discarded unreachable code: IL_0013, IL_0019, IL_0020, IL_0024, IL_002d, IL_0034
		//IL_0006: Invalid comparison between Unknown and I
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected F4, but got I8
		while (true)
		{
			if ((nint)/*Error near IL_0008: Stack underflow*/ >= (nint)385941504)
			{
			}
			if ((int)/*Error near IL_0008: Stack underflow*/ != 0)
			{
			}
		}
	}

	private extern void method_8(int int_2, int int_3);

	private extern void method_9(int int_2 = 0);

	private extern void method_10(ref Struct3 struct3_0, int int_2);

	private extern void method_11(uint uint_2);

	internal extern void method_12(ref Struct3 struct3_0, ref Struct3 struct3_1);

	private static extern uint smethod_0(ref Struct3 struct3_0, uint uint_2);

	internal void method_13(ref Struct3 struct3_0)
	{
		//Discarded unreachable code: IL_0007, IL_000d, IL_0016, IL_001c, IL_002a
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		while (true)
		{
		}
	}

	private unsafe static void smethod_1(ref Struct3 struct3_0, ref Struct3 struct3_1, bool bool_1, ref Struct3 struct3_2)
	{
		//Discarded unreachable code: IL_000e, IL_0011, IL_0026
		//IL_0002: Invalid comparison between Unknown and Ref
		//IL_0013: Expected I, but got Unknown
		while (!System.Runtime.CompilerServices.Unsafe.IsAddressLessThan(ref *(byte*)/*Error near IL_0007: Stack underflow*/, ref System.Runtime.CompilerServices.Unsafe.As<Struct3, byte>(ref struct3_2)))
		{
		}
		*(_003F*)(nint)/*Error near IL_0009: Stack underflow*/ = /*Error near IL_0009: Stack underflow*/;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	private static extern uint smethod_2(ref uint uint_2, uint uint_3, uint uint_4);

	private static extern uint smethod_3(ref uint uint_2, uint uint_3, uint uint_4);

	private static uint smethod_4(ref uint uint_2, uint uint_3, uint uint_4, uint uint_5)
	{
		//Discarded unreachable code: IL_0007, IL_000d
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Ignored invalid 'readonly' prefix
		_003F val = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		_ = ((byte[])/*Error near IL_0002: Stack underflow*/)[val];
		/*Error near IL_0002: Invalid metadata token*/;
	}
}
