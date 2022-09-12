using System.Runtime.CompilerServices;

internal class b1a52dee : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_25;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint num = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(num - 1);
		Struct2 struct2 = class52_0.c6a36180_0.f113e6df(num);
		num--;
		class52_0.c6a36180_0.method_0(num);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(num);
		Struct2 struct2_ = default(Struct2);
		struct2_.b3579a47(~(@struct.b5683088() | struct2.b5683088()));
		class52_0.c6a36180_0.f43586b2(num, struct2_);
		byte byte_ = (byte)(fae0f10.cf4ec1c9 | fae0f10.byte_9);
		byte byte_2 = class52_0.struct2_0[fae0f10.b4de136c].method_3();
		a41805c0.smethod_0(@struct.b5683088(), struct2.b5683088(), struct2_.b5683088(), struct2_.b5683088(), ref byte_2, byte_);
		class52_0.struct2_0[fae0f10.b4de136c].b65cc66b(byte_2);
		a82ced3b_0 = (a82ced3b)0;
	}
}
