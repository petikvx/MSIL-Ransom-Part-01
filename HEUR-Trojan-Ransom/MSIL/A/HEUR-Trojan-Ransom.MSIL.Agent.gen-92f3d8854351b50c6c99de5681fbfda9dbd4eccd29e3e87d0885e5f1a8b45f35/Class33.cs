using System.Runtime.CompilerServices;

internal class Class33 : df7d42ac
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_46;
	}

	private static ulong smethod_0(ulong ulong_0, ulong ulong_1)
	{
		ulong num = ulong_0 & 0xFFFFFFFFuL;
		ulong num2 = ulong_0 >> 32;
		ulong num3 = ulong_1 & 0xFFFFFFFFuL;
		ulong num4 = ulong_1 >> 32;
		ulong num5 = num * num3;
		num5 = num2 * num3 + (num5 >> 32);
		ulong num6 = num5 & 0xFFFFFFFFuL;
		ulong num7 = num5 >> 32;
		num5 = num6 + num * num4;
		num6 = num5 & 0xFFFFFFFFuL;
		return num7 + num2 * num4 + (num5 >> 32);
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint num = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(num - 1);
		facef383 facef385 = class58_0.c73f45d8.a9bb6dff(num);
		num--;
		class58_0.c73f45d8.a85b6a89(num);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(num);
		byte b = class58_0.a6890f1d[b13312b0.a048350c].a42951dc();
		facef383 facef383_ = default(facef383);
		ulong num2 = facef384.method_0() * facef385.method_0();
		facef383_.method_1(num2);
		class58_0.c73f45d8.method_0(num, facef383_);
		byte byte_ = (byte)(b13312b0.d805a5e9 | b13312b0.a8943634 | b13312b0.byte_12);
		byte b2 = (byte)(b13312b0.ad16d432 | b13312b0.byte_11);
		byte b3 = 0;
		if ((b & b13312b0.byte_12) != 0)
		{
			if (smethod_0(facef384.method_0(), facef385.method_0()) > 0L)
			{
				b3 = b2;
			}
		}
		else if (num2 >> 63 != (facef384.method_0() ^ facef385.method_0()) >> 63)
		{
			b3 = b2;
		}
		b = (byte)((b & ~b2) | b3);
		Class1.smethod_1(facef384.df1ed028(), facef385.method_0(), facef383_.method_0(), facef383_.method_0(), ref b, byte_);
		class58_0.a6890f1d[b13312b0.a048350c].method_4(b);
		enum0_0 = (Enum0)0;
	}
}
