using System;
using System.Reflection;

internal class d7ff815e : Interface1
{
	private object object_0;

	private FieldInfo fieldInfo_0;

	public d7ff815e(object object_1, FieldInfo fieldInfo_1)
	{
		object_0 = object_1;
		fieldInfo_0 = fieldInfo_1;
	}

	public Struct2 a421f925(Class52 class52_0, cf6ebfe8 cf6ebfe8_0)
	{
		object obj = object_0;
		if (fieldInfo_0.DeclaringType!.IsValueType && object_0 is Interface1)
		{
			obj = ((Interface1)object_0).a421f925(class52_0, (cf6ebfe8)4).method_9(fieldInfo_0.DeclaringType);
		}
		return Struct2.smethod_0(fieldInfo_0.GetValue(obj), fieldInfo_0.FieldType);
	}

	public unsafe void imethod_0(Class52 class52_0, Struct2 struct2_0, cf6ebfe8 cf6ebfe8_0)
	{
		if (fieldInfo_0.DeclaringType!.IsValueType && object_0 is Interface1)
		{
			TypedReference obj = default(TypedReference);
			((Interface1)object_0).imethod_1(class52_0, Struct1.d9a770c4(&obj), fieldInfo_0.DeclaringType);
			fieldInfo_0.SetValueDirect(obj, struct2_0.method_9(fieldInfo_0.FieldType));
		}
		else
		{
			fieldInfo_0.SetValue(object_0, struct2_0.method_9(fieldInfo_0.FieldType));
		}
	}

	public Interface1 aa5eee9f(uint uint_0)
	{
		return this;
	}

	public Interface1 aa5eee9f(ulong ulong_0)
	{
		return this;
	}

	public void imethod_1(Class52 class52_0, Struct1 struct1_0, Type type_0)
	{
		Class57.smethod_2(class52_0, object_0, fieldInfo_0, struct1_0);
	}
}
