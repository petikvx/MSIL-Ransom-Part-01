using System;
using System.Reflection;

internal class Class55 : Interface1
{
	private object object_0;

	private FieldInfo ea84c653;

	public Class55(object object_1, FieldInfo fieldInfo_0)
	{
		object_0 = object_1;
		ea84c653 = fieldInfo_0;
	}

	public Struct3 bb331190(fdc40966 fdc40966_0, f75d8d37 f75d8d37_0)
	{
		object obj = object_0;
		if (ea84c653.DeclaringType!.IsValueType && object_0 is Interface1)
		{
			obj = ((Interface1)object_0).bb331190(fdc40966_0, (f75d8d37)4).e3ce4628(ea84c653.DeclaringType);
		}
		return Struct3.smethod_0(ea84c653.GetValue(obj), ea84c653.FieldType);
	}

	public unsafe void ce1637af(fdc40966 fdc40966_0, Struct3 struct3_0, f75d8d37 f75d8d37_0)
	{
		if (ea84c653.DeclaringType!.IsValueType && object_0 is Interface1)
		{
			TypedReference obj = default(TypedReference);
			((Interface1)object_0).imethod_0(fdc40966_0, Struct2.smethod_0(&obj), ea84c653.DeclaringType);
			ea84c653.SetValueDirect(obj, struct3_0.e3ce4628(ea84c653.FieldType));
		}
		else
		{
			ea84c653.SetValue(object_0, struct3_0.e3ce4628(ea84c653.FieldType));
		}
	}

	public Interface1 fdd68142(uint uint_0)
	{
		return this;
	}

	public Interface1 fdd68142(ulong ulong_0)
	{
		return this;
	}

	public void imethod_0(fdc40966 fdc40966_0, Struct2 struct2_0, Type type_0)
	{
		Class61.smethod_4(fdc40966_0, object_0, ea84c653, struct2_0);
	}
}
