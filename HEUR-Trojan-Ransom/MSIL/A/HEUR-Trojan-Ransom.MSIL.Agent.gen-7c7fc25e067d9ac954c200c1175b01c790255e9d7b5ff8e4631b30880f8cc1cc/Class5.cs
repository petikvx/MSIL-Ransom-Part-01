using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class5 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_65;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num--);
		feeb32c3 feeb32c5 = class54_0.class55_0.ff4c393f(num);
		bool flag = (feeb32c4.method_0() & 0x80000000u) != 0;
		FieldInfo fieldInfo = (FieldInfo)class54_0.class1_0.method_0().method_2(feeb32c4.method_0() & 0x7FFFFFFFu);
		if (!fieldInfo.IsStatic && feeb32c5.cc3408c2() == null)
		{
			throw new NullReferenceException();
		}
		if (flag)
		{
			Class55 class55_ = class54_0.class55_0;
			uint uint_ = num;
			feeb32c3 feeb32c3_ = default(feeb32c3);
			feeb32c3_.method_7(new Class52(feeb32c5.cc3408c2(), fieldInfo));
			class55_.method_0(uint_, feeb32c3_);
		}
		else
		{
			object obj = ((!fieldInfo.DeclaringType!.IsValueType || !(feeb32c5.cc3408c2() is Interface2)) ? feeb32c5.method_9(fieldInfo.DeclaringType) : ((Interface2)feeb32c5.cc3408c2()).imethod_0(class54_0, (Enum1)4).method_9(fieldInfo.DeclaringType));
			class54_0.class55_0.method_0(num, feeb32c3.smethod_0(fieldInfo.GetValue(obj), fieldInfo.FieldType));
		}
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		a0aa499b_0 = (a0aa499b)0;
	}
}
