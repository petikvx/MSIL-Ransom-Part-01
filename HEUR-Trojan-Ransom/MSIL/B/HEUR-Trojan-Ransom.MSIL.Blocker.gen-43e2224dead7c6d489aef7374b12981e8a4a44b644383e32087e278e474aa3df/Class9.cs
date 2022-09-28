using System;
using VanillaStub.Helpers.Services.InputSimulator;
using VanillaStub.Helpers.Services.InputSimulator.Native;

internal class Class9 : IInputMessageDispatcher
{
	public extern void DispatchInput(INPUT[] inputs);

	public extern Class9();

	static extern ArgumentNullException smethod_0(string string_0);

	static ArgumentException smethod_1(string string_0, string string_1)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0021, IL_0027, IL_002f, IL_0038
		//IL_000e: Expected O, but got I4
		//IL_0017: Expected I4, but got F8
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and F4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		/*Error: stloc 1 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		//Discarded unreachable code: IL_0006
		_ = (uint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static int smethod_3(Type type_0)
	{
		//Discarded unreachable code: IL_001b, IL_0024, IL_0029
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I8
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			nuint num = (nuint)/*Error near IL_0001: Stack underflow*/;
			val = /*Error near IL_0003: Stack underflow*/% num;
		}
		while ((long)/*Error near IL_0009: Stack underflow*/ > (long)(ulong)val);
		uint num3;
		checked
		{
			nint num2 = (nint)/*Error near IL_000a: Stack underflow*/;
			/*OpCode not supported: DebugBreak*/;
			num3 = (uint)(/*Error near IL_000e: Stack underflow*/ + num2);
		}
		_ = ((float[])(/*Error near IL_0011: Stack underflow*/ >> (int)num3))[/*Error near IL_0011: ldloca 0 (out-of-bounds)*/];
		/*Error near IL_0014: ldloca 0 (out-of-bounds)*/;
		/*Error near IL_0016: Invalid metadata token*/;
	}

	unsafe static Exception smethod_4(string string_0)
	{
		//Discarded unreachable code: IL_0024, IL_002a, IL_0030
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected I8, but got I4
		//IL_0011: Expected I4, but got F8
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			uint num = ((uint[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
			ushort num2 = checked((ushort)(/*Error near IL_0005: Stack underflow*/ + num));
			*(long*)(nint)/*Error near IL_0009: Stack underflow*/ = (int)num2;
			if (/*Error near IL_000e: Stack underflow*/ >= /*Error near IL_000e: Stack underflow*/)
			{
				double num3 = ((double[])/*Error near IL_0010: Stack underflow*/)[/*Error near IL_0010: Stack underflow*/];
				((short[])/*Error near IL_0011: Stack underflow*/)[/*Error near IL_0011: Stack underflow*/] = (short)(int)num3;
				int num4;
				checked
				{
					num4 = (int)(*unchecked((double*)(nint)/*Error near IL_0012: Stack underflow*/));
				}
				if ((int)/*Error near IL_0018: Stack underflow*/ <= num4 && /*Error near IL_001d: Stack underflow*/>= /*Error near IL_001d: Stack underflow*/)
				{
					break;
				}
			}
		}
		*(_003F*)(nint)/*Error near IL_001e: Stack underflow*/ = /*Error near IL_001e: Stack underflow*/;
		/*Error near IL_001f: Invalid metadata token*/;
	}
}
