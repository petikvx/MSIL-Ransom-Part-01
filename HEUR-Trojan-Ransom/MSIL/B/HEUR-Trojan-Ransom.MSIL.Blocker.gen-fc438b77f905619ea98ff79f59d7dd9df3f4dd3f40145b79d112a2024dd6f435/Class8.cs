using System;
using System.Collections;
using System.Collections.Generic;
using VanillaStub.Helpers.Services.InputSimulator.Native;

internal class Class8 : IEnumerable<INPUT>, IEnumerable
{
	private readonly List<INPUT> list_0;

	public extern INPUT this[int int_0] { get; }

	public extern IEnumerator<INPUT> GetEnumerator();

	extern IEnumerator IEnumerable.GetEnumerator();

	public INPUT[] method_0()
	{
		_ = 4;
		throw ((float[])3.9485197415031706E+117)[5];
	}

	public static bool smethod_0(GEnum3 genum3_0)
	{
		//Discarded unreachable code: IL_0001, IL_0007, IL_0015, IL_001b, IL_0022, IL_002a
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected F4, but got I4
		//IL_0010: Expected I4, but got F8
		/*Error: Unknown opcode: 0xF8*/;
	}

	public extern Class8 method_1(GEnum3 genum3_0);

	public extern Class8 method_2(GEnum3 genum3_0);

	public extern Class8 method_3(GEnum3 genum3_0);

	public extern Class8 method_4(char char_0);

	public extern Class8 method_5(IEnumerable<char> ienumerable_0);

	public extern Class8 method_6(string string_0);

	public Class8 method_7(int int_0, int int_1)
	{
		//Discarded unreachable code: IL_0005, IL_000f, IL_001c, IL_0025
		//IL_000a: Invalid comparison between Unknown and F4
		//IL_0017: Expected I4, but got O
		//IL_0020: Invalid comparison between Unknown and I8
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	public Class8 method_8(int int_0, int int_1)
	{
		//Discarded unreachable code: IL_000c
		//IL_0001: Invalid comparison between Unknown and O
		object obj;
		do
		{
			obj = ((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		}
		while ((object)/*Error near IL_0006: Stack underflow*/ != obj);
		/*Error near IL_0007: Invalid metadata token*/;
	}

	public Class8 method_9(int int_0, int int_1)
	{
		//Discarded unreachable code: IL_000a, IL_0011, IL_0012, IL_0019, IL_001e, IL_0028, IL_0033, IL_0038
		//IL_0022: Expected I4, but got I8
		//IL_002e: Invalid comparison between Unknown and O
		checked
		{
			_ = (nint)((int[])/*Error near IL_0003: Stack underflow*/)[(object)null];
			/*Error near IL_0005: Invalid metadata token*/;
		}
	}

	public extern Class8 method_10(GEnum2 genum2_0);

	public Class8 method_11(int int_0)
	{
		//Discarded unreachable code: IL_0006
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public extern Class8 method_12(GEnum2 genum2_0);

	public extern Class8 method_13(int int_0);

	public extern Class8 method_14(GEnum2 genum2_0);

	public extern Class8 method_15(int int_0);

	public extern Class8 method_16(GEnum2 genum2_0);

	public Class8 method_17(int int_0)
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	public unsafe Class8 method_18(int int_0)
	{
		//Discarded unreachable code: IL_0017, IL_001d, IL_0022, IL_002a, IL_0034, IL_003f
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I8
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		double num;
		do
		{
			num = *(double*)(nint)/*Error near IL_0002: Stack underflow*/;
		}
		while ((long)(/*Error near IL_0006: Stack underflow*/ - num) < checked((long)/*Error near IL_0006: ldloca 0 (out-of-bounds)*/));
		nuint num2 = checked((nuint)/*Error near IL_000f: Stack underflow*/);
		_ = /*Error near IL_0012: Stack underflow*/| (double)num2;
		/*Error near IL_0012: Invalid metadata token*/;
	}

	public unsafe Class8 method_19(int int_0)
	{
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_000e: Incompatible stack heights: 0 vs 1
		do
		{
			/*Error: stloc 1 (out-of-bounds)*/;
			_ = ref this;
		}
		while ((int)/*Error near IL_0006: ldloca 0 (out-of-bounds)*/ > *(int*)int_0);
		_ = -0f;
		_ = 3;
		_ = 2.855096238232531E+230;
		/*Error: Unexpected end of block*/;
	}

	private static extern Enum2 smethod_1(GEnum2 genum2_0);

	private static extern Enum2 smethod_2(GEnum2 genum2_0);

	static extern bool smethod_3(IEnumerator ienumerator_0);

	static extern void smethod_4(IDisposable idisposable_0);

	static extern char[] smethod_5(string string_0);
}
