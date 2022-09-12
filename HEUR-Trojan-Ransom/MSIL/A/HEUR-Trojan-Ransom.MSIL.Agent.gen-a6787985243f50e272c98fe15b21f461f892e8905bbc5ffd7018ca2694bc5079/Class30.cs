using System.Runtime.CompilerServices;

internal class Class30 : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.b879ca13;
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

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint num = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(num - 1);
		Struct2 struct2 = class52_0.c6a36180_0.f113e6df(num);
		num--;
		class52_0.c6a36180_0.method_0(num);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(num);
		byte b7056385 = class52_0.struct2_0[fae0f10.b4de136c].method_3();
		Struct2 struct2_ = default(Struct2);
		ulong num2 = @struct.method_0() * struct2.method_0();
		struct2_.f6b2288d(num2);
		class52_0.c6a36180_0.f43586b2(num, struct2_);
		byte byte_ = (byte)(fae0f10.cf4ec1c9 | fae0f10.byte_9 | fae0f10.e2ea52e3);
		byte b7056386 = (byte)(fae0f10.bdee4792 | fae0f10.b28d533f);
		byte b7056387 = 0;
		if ((b7056385 & fae0f10.e2ea52e3) != 0)
		{
			if (smethod_0(@struct.method_0(), struct2.method_0()) > 0L)
			{
				b7056387 = b7056386;
			}
		}
		else if (num2 >> 63 != (@struct.method_0() ^ struct2.method_0()) >> 63)
		{
			b7056387 = b7056386;
		}
		b7056385 = (byte)((b7056385 & ~b7056386) | b7056387);
		a41805c0.smethod_1(@struct.b5683088(), struct2.method_0(), struct2_.method_0(), struct2_.method_0(), ref b7056385, byte_);
		class52_0.struct2_0[fae0f10.b4de136c].b65cc66b(b7056385);
		a82ced3b_0 = (a82ced3b)0;
	}
}
