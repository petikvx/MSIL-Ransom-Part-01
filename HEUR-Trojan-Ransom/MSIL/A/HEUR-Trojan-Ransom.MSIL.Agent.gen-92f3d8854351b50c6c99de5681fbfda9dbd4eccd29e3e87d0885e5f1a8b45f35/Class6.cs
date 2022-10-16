using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

internal class Class6 : d88be11e
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_67;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint uint_ = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(uint_--);
		facef383 facef385 = class58_0.c73f45d8.a9bb6dff(uint_--);
		Type type = (Type)class58_0.a3d704e3.method_0().method_2(facef384.df1ed028());
		if (facef385.method_8() is Interface0)
		{
			Interface0 @interface = (Interface0)facef385.method_8();
			facef383 facef383_ = default(facef383);
			if (type.IsValueType)
			{
				object object_ = null;
				if ((object)Nullable.GetUnderlyingType(type) == null)
				{
					object_ = FormatterServices.GetUninitializedObject(type);
				}
				facef383_.method_9(e94c75e3.f6ace54f(object_, type));
			}
			else
			{
				facef383_.method_9(null);
			}
			@interface.c076b3e0(class58_0, facef383_, (Enum1)4);
			class58_0.c73f45d8.a85b6a89(uint_);
			class58_0.a6890f1d[b13312b0.byte_7].method_2(uint_);
			enum0_0 = (Enum0)0;
			return;
		}
		throw new NotSupportedException();
	}
}
