using System;
using System.Runtime.CompilerServices;

internal class cefadc0d : f788ae7e
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.ce4dbb4c;
	}

	public unsafe void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint uint_ = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(uint_--);
		Struct2 struct2 = class52_0.c6a36180_0.f113e6df(uint_);
		bool flag = (@struct.b5683088() & 0x80000000u) != 0;
		Type type = (Type)class52_0.c8dafbc3.method_0().d3f1f142(@struct.b5683088() & 0x7FFFFFFFu);
		if (flag)
		{
			TypedReference typedReference_ = default(TypedReference);
			Class57.smethod_0(struct2.a90ed1e2(), Struct1.d9a770c4(&typedReference_));
			new Class51(typedReference_);
			struct2 = Struct2.smethod_0(struct2.a90ed1e2(), type);
			class52_0.c6a36180_0.f43586b2(uint_, struct2);
		}
		else
		{
			if ((object)type == typeof(object) && struct2.a90ed1e2() != null)
			{
				type = struct2.a90ed1e2().GetType();
			}
			struct2 = Struct2.smethod_0(struct2.a90ed1e2(), type);
			class52_0.c6a36180_0.f43586b2(uint_, struct2);
		}
		class52_0.c6a36180_0.method_0(uint_);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(uint_);
		a82ced3b_0 = (a82ced3b)0;
	}
}
