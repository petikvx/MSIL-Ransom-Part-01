using System.Runtime.CompilerServices;

internal class e0680a7f : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_15;
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
			((Interface1)@struct.a90ed1e2()).imethod_0(class52_0, struct2_, (cf6ebfe8)0);
		}
		else
		{
			byte b7056385 = struct2_.method_3();
			byte* ptr = (byte*)@struct.method_0();
			*ptr = b7056385;
		}
		a82ced3b_0 = (a82ced3b)0;
	}
}
