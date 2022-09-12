using System.Runtime.CompilerServices;

internal class e2b10479 : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_19;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint num = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		class52_0.c6a36180_0.method_0(++num);
		byte b7056385 = class52_0.method_0();
		Struct2 @struct = class52_0.struct2_0[b7056385];
		if (b7056385 == fae0f10.byte_5 || b7056385 == fae0f10.byte_4)
		{
			c6a36180 c6a36180_ = class52_0.c6a36180_0;
			uint uint_ = num;
			Struct2 struct2_ = default(Struct2);
			struct2_.method_7(new a32d2227(@struct.b5683088()));
			c6a36180_.f43586b2(uint_, struct2_);
		}
		else
		{
			c6a36180 c6a36180_2 = class52_0.c6a36180_0;
			uint uint_2 = num;
			Struct2 struct2_ = default(Struct2);
			struct2_.b3579a47(@struct.b5683088());
			c6a36180_2.f43586b2(uint_2, struct2_);
		}
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(num);
		a82ced3b_0 = (a82ced3b)0;
	}
}
