using System;
using System.Runtime.CompilerServices;

internal class e5fe365f : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_42;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint num = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		ulong num2 = class52_0.c6a36180_0.f113e6df(num--).method_0();
		int index = class52_0.b842fc37.Count - 1;
		ef6a318e ef6a318e2 = class52_0.b842fc37[index];
		if (ef6a318e2.ulong_1 != num2)
		{
			throw new InvalidProgramException();
		}
		class52_0.b842fc37.RemoveAt(index);
		if (ef6a318e2.byte_0 == fae0f10.b7ac966d)
		{
			class52_0.c6a36180_0.f43586b2(++num, class52_0.struct2_0[fae0f10.d1e82201]);
			class52_0.struct2_0[fae0f10.ccfef7db].b65cc66b(0);
			class52_0.struct2_0[fae0f10.d1e82201].f6b2288d(ef6a318e2.ulong_1);
		}
		class52_0.c6a36180_0.method_0(num);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(num);
		a82ced3b_0 = (a82ced3b)0;
	}
}
