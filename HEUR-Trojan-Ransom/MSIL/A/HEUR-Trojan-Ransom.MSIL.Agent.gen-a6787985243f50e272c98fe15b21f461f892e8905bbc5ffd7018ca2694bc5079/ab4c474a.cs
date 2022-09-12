using System.Runtime.CompilerServices;

internal class ab4c474a : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_39;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint uint_ = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 struct2_ = class52_0.c6a36180_0.f113e6df(uint_);
		byte b7056385 = (byte)(class52_0.struct2_0[fae0f10.b4de136c].method_3() & ~fae0f10.b28d533f);
		if (!Class0.ffeab2de && struct2_.method_0() >> 32 > 0L)
		{
			b7056385 = (byte)(b7056385 | fae0f10.b28d533f);
		}
		class52_0.struct2_0[fae0f10.b4de136c].b65cc66b(b7056385);
		class52_0.c6a36180_0.f43586b2(uint_, struct2_);
		a82ced3b_0 = (a82ced3b)0;
	}
}
