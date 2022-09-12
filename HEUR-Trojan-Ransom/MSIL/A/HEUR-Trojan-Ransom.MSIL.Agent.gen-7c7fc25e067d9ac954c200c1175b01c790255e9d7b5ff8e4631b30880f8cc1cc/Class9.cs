using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class9 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.ca25ba6a;
	}

	public unsafe void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num--);
		feeb32c3 feeb32c5 = class54_0.class55_0.ff4c393f(num--);
		feeb32c3 feeb32c6 = class54_0.class55_0.ff4c393f(num--);
		FieldInfo fieldInfo = (FieldInfo)class54_0.class1_0.method_0().method_2(feeb32c4.method_0());
		if (!fieldInfo.IsStatic && feeb32c6.cc3408c2() == null)
		{
			throw new NullReferenceException();
		}
		object value = ((Type.GetTypeCode(fieldInfo.FieldType) != TypeCode.String || feeb32c5.cc3408c2() != null) ? feeb32c5.method_9(fieldInfo.FieldType) : class54_0.class1_0.method_0().method_3(feeb32c5.method_0()));
		if (fieldInfo.DeclaringType!.IsValueType && feeb32c6.cc3408c2() is Interface2)
		{
			TypedReference obj = default(TypedReference);
			((Interface2)feeb32c6.cc3408c2()).imethod_3(class54_0, Struct1.smethod_0(&obj), fieldInfo.DeclaringType);
			Class59.smethod_0(Struct1.smethod_0(&obj), fieldInfo.DeclaringType);
			fieldInfo.SetValueDirect(obj, value);
		}
		else
		{
			fieldInfo.SetValue(feeb32c6.method_9(fieldInfo.DeclaringType), value);
		}
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		a0aa499b_0 = (a0aa499b)0;
	}
}
