using System.Runtime.CompilerServices;

internal class Class22 : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_38;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint uint_ = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 struct2_ = class52_0.c6a36180_0.f113e6df(uint_);
		byte b7056385 = class52_0.struct2_0[fae0f10.b4de136c].method_3();
		if ((b7056385 & fae0f10.e2ea52e3) != 0)
		{
			struct2_.method_4(struct2_.method_0());
		}
		else
		{
			struct2_.method_4((long)struct2_.method_0());
		}
		class52_0.struct2_0[fae0f10.b4de136c].b65cc66b((byte)(b7056385 & ~fae0f10.e2ea52e3));
		class52_0.c6a36180_0.f43586b2(uint_, struct2_);
		a82ced3b_0 = (a82ced3b)0;
	}
}
