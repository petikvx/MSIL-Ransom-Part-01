using System;
using System.Runtime.CompilerServices;

internal class Class49 : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.d73424d1;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint uint_ = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		byte b7056385 = class52_0.c6a36180_0.f113e6df(uint_--).method_3();
		ef6a318e item = default(ef6a318e);
		item.byte_0 = b7056385;
		if (b7056385 == fae0f10.ef8a8474)
		{
			item.type_0 = (Type)class52_0.c8dafbc3.method_0().d3f1f142(class52_0.c6a36180_0.f113e6df(uint_--).b5683088());
		}
		else if (b7056385 == fae0f10.byte_55)
		{
			item.ulong_0 = class52_0.c6a36180_0.f113e6df(uint_--).method_0();
		}
		item.ulong_1 = class52_0.c6a36180_0.f113e6df(uint_--).method_0();
		class52_0.c6a36180_0.method_0(uint_);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(uint_);
		item.struct2_0 = class52_0.struct2_0[fae0f10.byte_4];
		item.struct2_1 = class52_0.struct2_0[fae0f10.byte_5];
		class52_0.b842fc37.Add(item);
		a82ced3b_0 = (a82ced3b)0;
	}
}
