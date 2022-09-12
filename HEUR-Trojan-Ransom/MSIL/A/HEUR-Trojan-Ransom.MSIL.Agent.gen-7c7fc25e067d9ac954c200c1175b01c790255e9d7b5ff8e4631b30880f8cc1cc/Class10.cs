using System;
using System.Runtime.CompilerServices;

internal class Class10 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_67;
	}

	public unsafe void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num--);
		feeb32c3 feeb32c5 = class54_0.class55_0.ff4c393f(num);
		bool flag = (feeb32c4.method_0() & 0x80000000u) != 0;
		Type type = (Type)class54_0.class1_0.method_0().method_2(feeb32c4.method_0() & 0x7FFFFFFFu);
		if (flag)
		{
			TypedReference typedReference_ = default(TypedReference);
			Class59.b418db1(feeb32c5.cc3408c2(), Struct1.smethod_0(&typedReference_));
			new Class53(typedReference_);
			feeb32c5 = feeb32c3.smethod_0(feeb32c5.cc3408c2(), type);
			class54_0.class55_0.method_0(num, feeb32c5);
		}
		else
		{
			if ((object)type == typeof(object) && feeb32c5.cc3408c2() != null)
			{
				type = feeb32c5.cc3408c2().GetType();
			}
			feeb32c5 = feeb32c3.smethod_0(feeb32c5.cc3408c2(), type);
			class54_0.class55_0.method_0(num, feeb32c5);
		}
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		a0aa499b_0 = (a0aa499b)0;
	}
}
