using System.Runtime.CompilerServices;

internal class Class29 : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.e0b2997a;
	}

	public unsafe void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint uint_ = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(uint_);
		Struct2 struct2_;
		if (@struct.a90ed1e2() is Interface1)
		{
			struct2_ = ((Interface1)@struct.a90ed1e2()).a421f925(class52_0, Class0.ffeab2de ? ((cf6ebfe8)3) : ((cf6ebfe8)2));
		}
		else if (Class0.ffeab2de)
		{
			ulong* ptr = (ulong*)@struct.method_0();
			Struct2 struct2 = default(Struct2);
			struct2.f6b2288d(*ptr);
			struct2_ = struct2;
		}
		else
		{
			uint* ptr2 = (uint*)@struct.method_0();
			Struct2 struct2 = default(Struct2);
			struct2.b3579a47(*ptr2);
			struct2_ = struct2;
		}
		class52_0.c6a36180_0.f43586b2(uint_, struct2_);
		a82ced3b_0 = (a82ced3b)0;
	}
}
