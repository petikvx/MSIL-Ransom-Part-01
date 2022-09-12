using System.Runtime.CompilerServices;

internal class Class23 : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_40;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint uint_ = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 struct2_ = class52_0.c6a36180_0.f113e6df(uint_);
		double num = struct2_.d6a6a8ce();
		struct2_.f6b2288d((ulong)(long)num);
		byte b7056385 = (byte)(class52_0.struct2_0[fae0f10.b4de136c].method_3() & ~fae0f10.b28d533f);
		if ((b7056385 & fae0f10.e2ea52e3) != 0)
		{
			if (!(num > -1.0) || !(num < 1.8446744073709552E+19))
			{
				b7056385 = (byte)(b7056385 | fae0f10.b28d533f);
			}
			if (!(num < 9.223372036854776E+18))
			{
				struct2_.f6b2288d((ulong)((double)(long)num - 9.223372036854776E+18) + 9223372036854775808uL);
			}
		}
		else if (!(num > -9.223372036854778E+18) || !(num < 9.223372036854776E+18))
		{
			b7056385 = (byte)(b7056385 | fae0f10.b28d533f);
		}
		class52_0.struct2_0[fae0f10.b4de136c].b65cc66b((byte)(b7056385 & ~fae0f10.e2ea52e3));
		class52_0.c6a36180_0.f43586b2(uint_, struct2_);
		a82ced3b_0 = (a82ced3b)0;
	}
}
