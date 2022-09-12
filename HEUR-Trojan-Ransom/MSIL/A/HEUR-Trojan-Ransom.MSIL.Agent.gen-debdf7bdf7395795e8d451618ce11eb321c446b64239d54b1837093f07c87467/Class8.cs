using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class8 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.byte_60;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint uint_ = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 struct2_ = class49_0.ec45936d.a59d7f30(uint_);
		MemberInfo memberInfo = class49_0.class2_0.c73a3276().a9b0159f(struct2_.method_2());
		if (memberInfo is Type)
		{
			struct2_.method_7(a4609aa4.ba1b63c0(((Type)memberInfo).TypeHandle, typeof(RuntimeTypeHandle)));
		}
		else if (memberInfo is MethodBase)
		{
			struct2_.method_7(a4609aa4.ba1b63c0(((MethodBase)memberInfo).MethodHandle, typeof(RuntimeMethodHandle)));
		}
		else if (memberInfo is FieldInfo)
		{
			struct2_.method_7(a4609aa4.ba1b63c0(((FieldInfo)memberInfo).FieldHandle, typeof(RuntimeFieldHandle)));
		}
		class49_0.ec45936d.d1cb88cf(uint_, struct2_);
		enum1_0 = (Enum1)0;
	}
}
