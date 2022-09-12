using System;
using System.Reflection;

internal class Class59 : Interface1
{
	private object object_0;

	private FieldInfo fieldInfo_0;

	public Class59(object object_1, FieldInfo fieldInfo_1)
	{
		object_0 = object_1;
		fieldInfo_0 = fieldInfo_1;
	}

	public ebd9b488 imethod_0(Class62 class62_0, Enum2 enum2_0)
	{
		object obj = object_0;
		if (fieldInfo_0.DeclaringType!.IsValueType && object_0 is Interface1)
		{
			obj = ((Interface1)object_0).imethod_0(class62_0, (Enum2)4).method_5(fieldInfo_0.DeclaringType);
		}
		return ebd9b488.e37ec81d(fieldInfo_0.GetValue(obj), fieldInfo_0.FieldType);
	}

	public unsafe void e44a2829(Class62 class62_0, ebd9b488 ebd9b488_0, Enum2 enum2_0)
	{
		if (fieldInfo_0.DeclaringType!.IsValueType && object_0 is Interface1)
		{
			TypedReference obj = default(TypedReference);
			((Interface1)object_0).imethod_3(class62_0, f06aee96.smethod_0(&obj), fieldInfo_0.DeclaringType);
			fieldInfo_0.SetValueDirect(obj, ebd9b488_0.method_5(fieldInfo_0.FieldType));
		}
		else
		{
			fieldInfo_0.SetValue(object_0, ebd9b488_0.method_5(fieldInfo_0.FieldType));
		}
	}

	public Interface1 imethod_1(uint uint_0)
	{
		return this;
	}

	public Interface1 imethod_2(ulong ulong_0)
	{
		return this;
	}

	public void imethod_3(Class62 class62_0, f06aee96 f06aee96_0, Type type_0)
	{
		bc2a451.smethod_5(class62_0, object_0, fieldInfo_0, f06aee96_0);
	}
}
