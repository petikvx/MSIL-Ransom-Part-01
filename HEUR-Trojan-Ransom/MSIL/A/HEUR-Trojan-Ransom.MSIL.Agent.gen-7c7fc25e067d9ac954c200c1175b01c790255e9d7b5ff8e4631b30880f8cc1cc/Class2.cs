using System;
using System.Runtime.CompilerServices;

internal class Class2 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.bcf9a6c1;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num--);
		feeb32c3 feeb32c3_ = class54_0.class55_0.ff4c393f(num);
		Type type = (Type)class54_0.class1_0.method_0().method_2(feeb32c4.method_0());
		if (Type.GetTypeCode(type) == TypeCode.String && feeb32c3_.cc3408c2() == null)
		{
			feeb32c3_.method_7(class54_0.class1_0.method_0().method_3(feeb32c3_.method_0()));
		}
		else
		{
			feeb32c3_.method_7(feeb32c3_.method_9(type));
		}
		class54_0.class55_0.method_0(num, feeb32c3_);
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		a0aa499b_0 = (a0aa499b)0;
	}
}
