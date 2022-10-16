using System;
using System.Runtime.CompilerServices;

internal class Class12 : d88be11e
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_72;
	}

	public unsafe void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint uint_ = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(uint_--);
		facef383 facef385 = class58_0.c73f45d8.a9bb6dff(uint_);
		bool flag = (facef384.df1ed028() & 0x80000000u) != 0;
		Type type = (Type)class58_0.a3d704e3.method_0().method_2(facef384.df1ed028() & 0x7FFFFFFFu);
		if (flag)
		{
			TypedReference typedReference_ = default(TypedReference);
			Class63.a1521871(facef385.method_8(), Struct0.smethod_0(&typedReference_));
			new Class57(typedReference_);
			facef385 = facef383.b3e8ed04(facef385.method_8(), type);
			class58_0.c73f45d8.method_0(uint_, facef385);
		}
		else
		{
			if ((object)type == typeof(object) && facef385.method_8() != null)
			{
				type = facef385.method_8().GetType();
			}
			facef385 = facef383.b3e8ed04(facef385.method_8(), type);
			class58_0.c73f45d8.method_0(uint_, facef385);
		}
		class58_0.c73f45d8.a85b6a89(uint_);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(uint_);
		enum0_0 = (Enum0)0;
	}
}
