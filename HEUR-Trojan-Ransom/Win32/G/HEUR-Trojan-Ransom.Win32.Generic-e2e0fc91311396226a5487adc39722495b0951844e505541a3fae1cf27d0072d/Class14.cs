using System;

internal sealed class Class14
{
	protected internal unsafe static byte[] smethod_0(byte[] byte_0)
	{
		//Discarded unreachable code: IL_0011, IL_0016, IL_001b, IL_0029, IL_0034, IL_003c
		//IL_0002: Expected F4, but got I4
		//IL_002b: Expected F8, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		byte num = checked((byte)/*Error near IL_0001: Stack underflow*/);
		*(float*)(nint)/*Error near IL_0002: Stack underflow*/ = (int)num;
		_ = 1663780052L;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	public extern Class14();

	unsafe static void smethod_1(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Ref
		do
		{
			_003F val = /*Error near IL_0001: Stack underflow*/& /*Error near IL_0001: Stack underflow*/;
			_003F val2 = /*Error near IL_0002: Stack underflow*/>> (int)val;
			_003F val3 = /*Error near IL_0004: Stack underflow*/* val2;
			_003F val4 = /*Error near IL_0005: Stack underflow*/>> (int)val3;
			checked
			{
				_ = (double)(short)unchecked((int)((uint[])/*Error near IL_0006: Stack underflow*/)[val4]);
				/*Error near IL_0008: stloc 3 (out-of-bounds)*/;
			}
		}
		while ((nint)(*(IntPtr*)(nint)/*Error near IL_000a: Stack underflow*/) <= (nint)((Array)(&array_0)).LongLength);
		((float[])/*Error near IL_0014: Stack underflow*/)[/*Error near IL_0014: Stack underflow*/] = (float)/*Error near IL_0014: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	static extern ArgumentNullException smethod_2(string string_0);
}
