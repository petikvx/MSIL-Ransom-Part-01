using System.Runtime.CompilerServices;

internal class ff4a1ae5 : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.b47df7b1;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint num = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(num);
		Struct2 struct2 = class52_0.c6a36180_0.f113e6df(num - 1);
		num -= 2;
		class52_0.c6a36180_0.method_0(num);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(num);
		if (struct2.method_0() > 0L)
		{
			class52_0.struct2_0[fae0f10.d1e82201].f6b2288d(@struct.method_0());
		}
		a82ced3b_0 = (a82ced3b)0;
	}
}
