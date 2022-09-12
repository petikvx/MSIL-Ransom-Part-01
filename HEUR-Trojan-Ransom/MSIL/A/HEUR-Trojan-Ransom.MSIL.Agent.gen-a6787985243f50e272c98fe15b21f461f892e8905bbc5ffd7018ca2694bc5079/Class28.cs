using System;
using System.Runtime.CompilerServices;

internal class Class28 : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.cb915a91;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint uint_ = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(uint_);
		if (!(@struct.a90ed1e2() is Interface1))
		{
			throw new ExecutionEngineException();
		}
		Struct2 struct2_ = ((Interface1)@struct.a90ed1e2()).a421f925(class52_0, (cf6ebfe8)4);
		class52_0.c6a36180_0.f43586b2(uint_, struct2_);
		a82ced3b_0 = (a82ced3b)0;
	}
}
