using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class7 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.d1c44107;
	}

	public unsafe void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(num--);
		Struct2 struct2 = class49_0.ec45936d.a59d7f30(num--);
		Struct2 struct3 = class49_0.ec45936d.a59d7f30(num--);
		FieldInfo fieldInfo = (FieldInfo)class49_0.class2_0.c73a3276().a9b0159f(@struct.method_2());
		if (!fieldInfo.IsStatic && struct3.method_6() == null)
		{
			throw new NullReferenceException();
		}
		object value = ((Type.GetTypeCode(fieldInfo.FieldType) != TypeCode.String || struct2.method_6() != null) ? struct2.method_8(fieldInfo.FieldType) : class49_0.class2_0.c73a3276().method_3(struct2.method_2()));
		if (fieldInfo.DeclaringType!.IsValueType && struct3.method_6() is da5e0024)
		{
			TypedReference obj = default(TypedReference);
			((da5e0024)struct3.method_6()).c4cba08f(class49_0, fe387972.smethod_0(&obj), fieldInfo.DeclaringType);
			Class55.dae92d78(fe387972.smethod_0(&obj), fieldInfo.DeclaringType);
			fieldInfo.SetValueDirect(obj, value);
		}
		else
		{
			fieldInfo.SetValue(struct3.method_8(fieldInfo.DeclaringType), value);
		}
		class49_0.ec45936d.method_0(num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		enum1_0 = (Enum1)0;
	}
}
