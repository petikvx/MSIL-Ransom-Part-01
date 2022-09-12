using System.Runtime.CompilerServices;

internal class Class33 : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_16;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint num = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(num);
		class52_0.c6a36180_0.method_0(--num);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(num);
		byte b7056385 = class52_0.method_0();
		if ((b7056385 == fae0f10.byte_5 || b7056385 == fae0f10.byte_4) && @struct.a90ed1e2() is a32d2227)
		{
			Struct2[] struct2_ = class52_0.struct2_0;
			Struct2 struct2 = default(Struct2);
			struct2.b3579a47(((a32d2227)@struct.a90ed1e2()).d724395a());
			struct2_[b7056385] = struct2;
		}
		else
		{
			class52_0.struct2_0[b7056385] = @struct;
		}
		a82ced3b_0 = (a82ced3b)0;
	}
}
