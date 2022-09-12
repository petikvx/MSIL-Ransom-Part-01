using System.Runtime.CompilerServices;

internal class f3952d26 : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_13;
	}

	public unsafe void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint uint_ = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(uint_--);
		Struct2 struct2_ = class52_0.c6a36180_0.f113e6df(uint_--);
		class52_0.c6a36180_0.method_0(uint_);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(uint_);
		if (@struct.a90ed1e2() is Interface1)
		{
			((Interface1)@struct.a90ed1e2()).imethod_0(class52_0, struct2_, Class0.ffeab2de ? ((cf6ebfe8)3) : ((cf6ebfe8)2));
		}
		else if (Class0.ffeab2de)
		{
			ulong* ptr = (ulong*)@struct.method_0();
			*ptr = struct2_.method_0();
		}
		else
		{
			uint* ptr2 = (uint*)@struct.method_0();
			*ptr2 = struct2_.b5683088();
		}
		a82ced3b_0 = (a82ced3b)0;
	}
}
