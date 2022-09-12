using System.Runtime.CompilerServices;

internal class Class35 : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_18;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint num = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		class52_0.c6a36180_0.method_0(++num);
		byte b7056385 = class52_0.method_0();
		Struct2 @struct = class52_0.struct2_0[b7056385];
		c6a36180 c6a36180_ = class52_0.c6a36180_0;
		uint uint_ = num;
		Struct2 struct2_ = default(Struct2);
		struct2_.method_2(@struct.method_1());
		c6a36180_.f43586b2(uint_, struct2_);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(num);
		a82ced3b_0 = (a82ced3b)0;
	}
}
