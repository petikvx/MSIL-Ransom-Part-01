using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

internal class a98ed11c : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.byte_58;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(num--);
		Struct2 struct2 = class49_0.ec45936d.a59d7f30(num--);
		Type type = (Type)class49_0.class2_0.c73a3276().a9b0159f(@struct.method_2());
		if (struct2.method_6() is da5e0024)
		{
			da5e0024 da5e25 = (da5e0024)struct2.method_6();
			Struct2 struct2_ = default(Struct2);
			if (type.IsValueType)
			{
				object object_ = null;
				if ((object)Nullable.GetUnderlyingType(type) == null)
				{
					object_ = FormatterServices.GetUninitializedObject(type);
				}
				struct2_.method_7(a4609aa4.ba1b63c0(object_, type));
			}
			else
			{
				struct2_.method_7(null);
			}
			da5e25.bf75e195(class49_0, struct2_, (Enum2)4);
			class49_0.ec45936d.method_0(num);
			class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
			enum1_0 = (Enum1)0;
			return;
		}
		throw new NotSupportedException();
	}
}
