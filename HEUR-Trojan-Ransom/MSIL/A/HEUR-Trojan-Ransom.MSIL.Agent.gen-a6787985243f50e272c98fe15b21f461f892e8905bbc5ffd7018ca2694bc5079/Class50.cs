using System.Runtime.CompilerServices;

internal class Class50 : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_41;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint num = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(num);
		class52_0.c6a36180_0.method_0(--num);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(num);
		f788ae7e f788ae7e2 = Class61.smethod_0(@struct.method_3());
		f788ae7e2.imethod_0(class52_0, out a82ced3b_0);
	}
}
