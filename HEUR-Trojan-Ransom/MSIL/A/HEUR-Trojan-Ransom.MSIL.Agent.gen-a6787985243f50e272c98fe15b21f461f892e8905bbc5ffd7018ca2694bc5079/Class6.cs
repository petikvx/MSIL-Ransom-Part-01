using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class6 : f788ae7e
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.f47e5833;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint num = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(num--);
		Struct2 struct2 = class52_0.c6a36180_0.f113e6df(num);
		bool flag = (@struct.b5683088() & 0x80000000u) != 0;
		FieldInfo fieldInfo = (FieldInfo)class52_0.c8dafbc3.method_0().d3f1f142(@struct.b5683088() & 0x7FFFFFFFu);
		if (!fieldInfo.IsStatic && struct2.a90ed1e2() == null)
		{
			throw new NullReferenceException();
		}
		if (flag)
		{
			c6a36180 c6a36180_ = class52_0.c6a36180_0;
			uint uint_ = num;
			Struct2 struct2_ = default(Struct2);
			struct2_.method_7(new d7ff815e(struct2.a90ed1e2(), fieldInfo));
			c6a36180_.f43586b2(uint_, struct2_);
		}
		else
		{
			object obj = ((!fieldInfo.DeclaringType!.IsValueType || !(struct2.a90ed1e2() is Interface1)) ? struct2.method_9(fieldInfo.DeclaringType) : ((Interface1)struct2.a90ed1e2()).a421f925(class52_0, (cf6ebfe8)4).method_9(fieldInfo.DeclaringType));
			class52_0.c6a36180_0.f43586b2(num, Struct2.smethod_0(fieldInfo.GetValue(obj), fieldInfo.FieldType));
		}
		class52_0.c6a36180_0.method_0(num);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(num);
		a82ced3b_0 = (a82ced3b)0;
	}
}
