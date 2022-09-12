using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class13 : f788ae7e
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.f692b6dd;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint uint_ = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 struct2_ = class52_0.c6a36180_0.f113e6df(uint_);
		MemberInfo memberInfo = class52_0.c8dafbc3.method_0().d3f1f142(struct2_.b5683088());
		if (memberInfo is Type)
		{
			struct2_.method_7(Class59.smethod_0(((Type)memberInfo).TypeHandle, typeof(RuntimeTypeHandle)));
		}
		else if (memberInfo is MethodBase)
		{
			struct2_.method_7(Class59.smethod_0(((MethodBase)memberInfo).MethodHandle, typeof(RuntimeMethodHandle)));
		}
		else if (memberInfo is FieldInfo)
		{
			struct2_.method_7(Class59.smethod_0(((FieldInfo)memberInfo).FieldHandle, typeof(RuntimeFieldHandle)));
		}
		class52_0.c6a36180_0.f43586b2(uint_, struct2_);
		a82ced3b_0 = (a82ced3b)0;
	}
}
