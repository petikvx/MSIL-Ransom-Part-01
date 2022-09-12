using System;
using System.Reflection;

internal class Class52 : Interface2
{
	private object dbb25589;

	private FieldInfo ccf2e154;

	public Class52(object object_0, FieldInfo fieldInfo_0)
	{
		dbb25589 = object_0;
		ccf2e154 = fieldInfo_0;
	}

	public feeb32c3 imethod_0(Class54 class54_0, Enum1 enum1_0)
	{
		object obj = dbb25589;
		if (ccf2e154.DeclaringType!.IsValueType && dbb25589 is Interface2)
		{
			obj = ((Interface2)dbb25589).imethod_0(class54_0, (Enum1)4).method_9(ccf2e154.DeclaringType);
		}
		return feeb32c3.smethod_0(ccf2e154.GetValue(obj), ccf2e154.FieldType);
	}

	public unsafe void edfcdc20(Class54 class54_0, feeb32c3 feeb32c3_0, Enum1 enum1_0)
	{
		if (ccf2e154.DeclaringType!.IsValueType && dbb25589 is Interface2)
		{
			TypedReference obj = default(TypedReference);
			((Interface2)dbb25589).imethod_3(class54_0, Struct1.smethod_0(&obj), ccf2e154.DeclaringType);
			ccf2e154.SetValueDirect(obj, feeb32c3_0.method_9(ccf2e154.FieldType));
		}
		else
		{
			ccf2e154.SetValue(dbb25589, feeb32c3_0.method_9(ccf2e154.FieldType));
		}
	}

	public Interface2 imethod_1(uint uint_0)
	{
		return this;
	}

	public Interface2 imethod_2(ulong ulong_0)
	{
		return this;
	}

	public void imethod_3(Class54 class54_0, Struct1 struct1_0, Type type_0)
	{
		Class59.smethod_1(class54_0, dbb25589, ccf2e154, struct1_0);
	}
}
