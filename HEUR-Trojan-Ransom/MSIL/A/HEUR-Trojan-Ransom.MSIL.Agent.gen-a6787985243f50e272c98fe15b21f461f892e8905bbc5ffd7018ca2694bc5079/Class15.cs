using System.Runtime.CompilerServices;

internal class Class15 : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.dc7c5575;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint num = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(num - 1);
		Struct2 struct2 = class52_0.c6a36180_0.f113e6df(num);
		num--;
		class52_0.c6a36180_0.method_0(num);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(num);
		Struct2 struct2_ = default(Struct2);
		if (@struct.a90ed1e2() is Interface1)
		{
			struct2_.method_7(((Interface1)@struct.a90ed1e2()).aa5eee9f(struct2.method_0()));
		}
		else if (struct2.a90ed1e2() is Interface1)
		{
			struct2_.method_7(((Interface1)struct2.a90ed1e2()).aa5eee9f(@struct.method_0()));
		}
		else
		{
			struct2_.f6b2288d(struct2.method_0() + @struct.method_0());
		}
		class52_0.c6a36180_0.f43586b2(num, struct2_);
		byte byte_ = (byte)(fae0f10.cf4ec1c9 | fae0f10.byte_9 | fae0f10.b28d533f | fae0f10.bdee4792);
		byte byte_2 = class52_0.struct2_0[fae0f10.b4de136c].method_3();
		a41805c0.smethod_1(@struct.method_0(), struct2.method_0(), struct2_.method_0(), struct2_.method_0(), ref byte_2, byte_);
		class52_0.struct2_0[fae0f10.b4de136c].b65cc66b(byte_2);
		a82ced3b_0 = (a82ced3b)0;
	}
}
