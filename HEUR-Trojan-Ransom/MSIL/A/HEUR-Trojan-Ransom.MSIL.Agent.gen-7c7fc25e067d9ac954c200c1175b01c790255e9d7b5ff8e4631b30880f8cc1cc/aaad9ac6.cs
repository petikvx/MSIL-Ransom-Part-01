using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class aaad9ac6 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_66;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint uint_ = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c3_ = class54_0.class55_0.ff4c393f(uint_);
		MemberInfo memberInfo = class54_0.class1_0.method_0().method_2(feeb32c3_.method_0());
		if (memberInfo is Type)
		{
			feeb32c3_.method_7(Class60.smethod_0(((Type)memberInfo).TypeHandle, typeof(RuntimeTypeHandle)));
		}
		else if (memberInfo is MethodBase)
		{
			feeb32c3_.method_7(Class60.smethod_0(((MethodBase)memberInfo).MethodHandle, typeof(RuntimeMethodHandle)));
		}
		else if (memberInfo is FieldInfo)
		{
			feeb32c3_.method_7(Class60.smethod_0(((FieldInfo)memberInfo).FieldHandle, typeof(RuntimeFieldHandle)));
		}
		class54_0.class55_0.method_0(uint_, feeb32c3_);
		a0aa499b_0 = (a0aa499b)0;
	}
}
