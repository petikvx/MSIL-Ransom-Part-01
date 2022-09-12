using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class11 : bae6a63f
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.ff3b23b;
	}

	public unsafe void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(num--);
		ebd9b488 ebd9b490 = class62_0.class64_0.method_0(num--);
		ebd9b488 ebd9b491 = class62_0.class64_0.method_0(num--);
		FieldInfo fieldInfo = (FieldInfo)class62_0.da79a168.de5d16da().method_3(ebd9b489.b585a11());
		if (!fieldInfo.IsStatic && ebd9b491.ec0d6773() == null)
		{
			throw new NullReferenceException();
		}
		object value = ((Type.GetTypeCode(fieldInfo.FieldType) != TypeCode.String || ebd9b490.ec0d6773() != null) ? ebd9b490.method_5(fieldInfo.FieldType) : class62_0.da79a168.de5d16da().method_4(ebd9b490.b585a11()));
		if (fieldInfo.DeclaringType!.IsValueType && ebd9b491.ec0d6773() is Interface1)
		{
			TypedReference obj = default(TypedReference);
			((Interface1)ebd9b491.ec0d6773()).imethod_3(class62_0, f06aee96.smethod_0(&obj), fieldInfo.DeclaringType);
			bc2a451.smethod_0(f06aee96.smethod_0(&obj), fieldInfo.DeclaringType);
			fieldInfo.SetValueDirect(obj, value);
		}
		else
		{
			fieldInfo.SetValue(ebd9b491.method_5(fieldInfo.DeclaringType), value);
		}
		class62_0.class64_0.method_2(num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		enum1_0 = (Enum1)0;
	}
}
