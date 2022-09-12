using System.Runtime.CompilerServices;

internal class b033b24f : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.d7e6c903;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint num = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(num - 1);
		Struct2 struct2 = class52_0.c6a36180_0.f113e6df(num);
		num -= 2;
		class52_0.c6a36180_0.method_0(num);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(num);
		int num2 = ((@struct.a90ed1e2() != struct2.a90ed1e2()) ? (-1) : 0);
		byte b7056385 = (byte)(fae0f10.cf4ec1c9 | fae0f10.byte_9 | fae0f10.b28d533f | fae0f10.bdee4792);
		byte b7056386 = (byte)(class52_0.struct2_0[fae0f10.b4de136c].method_3() & ~b7056385);
		if (num2 == 0)
		{
			b7056386 = (byte)(b7056386 | fae0f10.cf4ec1c9);
		}
		else if (num2 < 0)
		{
			b7056386 = (byte)(b7056386 | fae0f10.byte_9);
		}
		class52_0.struct2_0[fae0f10.b4de136c].b65cc66b(b7056386);
		a82ced3b_0 = (a82ced3b)0;
	}
}
