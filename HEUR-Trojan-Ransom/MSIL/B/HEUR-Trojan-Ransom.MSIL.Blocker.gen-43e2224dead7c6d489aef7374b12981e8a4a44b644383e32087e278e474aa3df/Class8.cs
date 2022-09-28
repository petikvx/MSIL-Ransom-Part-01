using System;
using System.Collections;
using System.Collections.Generic;
using VanillaStub.Helpers.Services.InputSimulator.Native;

internal class Class8 : IEnumerable<INPUT>, IEnumerable
{
	private readonly List<INPUT> list_0;

	public extern INPUT this[int int_0] { get; }

	public extern Class8();

	public extern IEnumerator<INPUT> GetEnumerator();

	extern IEnumerator IEnumerable.GetEnumerator();

	public extern INPUT[] method_0();

	public static extern bool smethod_0(GEnum3 genum3_0);

	public extern Class8 method_1(GEnum3 genum3_0);

	public extern Class8 method_2(GEnum3 genum3_0);

	public extern Class8 method_3(GEnum3 genum3_0);

	public extern Class8 method_4(char char_0);

	public extern Class8 method_5(IEnumerable<char> ienumerable_0);

	public extern Class8 method_6(string string_0);

	public extern Class8 method_7(int int_0, int int_1);

	public extern Class8 method_8(int int_0, int int_1);

	public Class8 method_9(int int_0, int int_1)
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_001b, IL_0021, IL_0026
		//IL_0004: Expected O, but got Unknown
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		IntPtr intPtr = (nint)((Array)/*Error near IL_0001: Stack underflow*/).LongLength;
		this = (Class8)/*Error near IL_0001: ldloc 1 (out-of-bounds)*/;
		_ = /*Error near IL_0005: Stack underflow*/<< (int)(nint)intPtr;
		/*Error near IL_0005: Unknown opcode: 0xF8*/;
	}

	public extern Class8 method_10(GEnum2 genum2_0);

	public extern Class8 method_11(int int_0);

	public extern Class8 method_12(GEnum2 genum2_0);

	public extern Class8 method_13(int int_0);

	public extern Class8 method_14(GEnum2 genum2_0);

	public Class8 method_15(int int_0)
	{
		//Discarded unreachable code: IL_0004, IL_0010, IL_0015, IL_0026, IL_002c
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I8
		//IL_000b: Incompatible stack heights: 0 vs 1
		//IL_0016: Expected native int or pointer, but got F8
		//IL_001d: Expected F4, but got I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0003: Unknown opcode: 0xFB*/;
	}

	public extern Class8 method_16(GEnum2 genum2_0);

	public Class8 method_17(int int_0)
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_000c
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	public extern Class8 method_18(int int_0);

	public extern Class8 method_19(int int_0);

	private static extern Enum2 smethod_1(GEnum2 genum2_0);

	private static extern Enum2 smethod_2(GEnum2 genum2_0);

	static extern bool smethod_3(IEnumerator ienumerator_0);

	static extern void smethod_4(IDisposable idisposable_0);

	static extern char[] smethod_5(string string_0);
}
