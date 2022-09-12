using System;
using System.Runtime.CompilerServices;

internal class b65d1239 : f788ae7e
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.a2004cf0;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint uint_ = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(uint_--);
		Struct2 struct2_ = class52_0.c6a36180_0.f113e6df(uint_);
		bool flag = (@struct.b5683088() & 0x80000000u) != 0;
		Type type = (Type)class52_0.c8dafbc3.method_0().d3f1f142(@struct.b5683088() & 0x7FFFFFFFu);
		if (Type.GetTypeCode(type) == TypeCode.String && struct2_.a90ed1e2() == null)
		{
			struct2_.method_7(class52_0.c8dafbc3.method_0().f54a7fb9(struct2_.b5683088()));
		}
		else if (struct2_.a90ed1e2() == null)
		{
			struct2_.method_7(null);
		}
		else if (!type.IsInstanceOfType(struct2_.a90ed1e2()))
		{
			struct2_.method_7(null);
			if (flag)
			{
				throw new InvalidCastException();
			}
		}
		class52_0.c6a36180_0.f43586b2(uint_, struct2_);
		class52_0.c6a36180_0.method_0(uint_);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(uint_);
		a82ced3b_0 = (a82ced3b)0;
	}
}
