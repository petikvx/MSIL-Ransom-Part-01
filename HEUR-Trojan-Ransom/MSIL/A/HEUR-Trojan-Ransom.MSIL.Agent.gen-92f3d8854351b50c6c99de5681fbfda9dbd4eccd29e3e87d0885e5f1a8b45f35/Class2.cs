using System;
using System.Runtime.CompilerServices;

internal class Class2 : d88be11e
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_63;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint uint_ = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(uint_--);
		facef383 facef383_ = class58_0.c73f45d8.a9bb6dff(uint_);
		bool flag = (facef384.df1ed028() & 0x80000000u) != 0;
		Type type = (Type)class58_0.a3d704e3.method_0().method_2(facef384.df1ed028() & 0x7FFFFFFFu);
		if (Type.GetTypeCode(type) == TypeCode.String && facef383_.method_8() == null)
		{
			facef383_.method_9(class58_0.a3d704e3.method_0().method_3(facef383_.df1ed028()));
		}
		else if (facef383_.method_8() == null)
		{
			facef383_.method_9(null);
		}
		else if (!type.IsInstanceOfType(facef383_.method_8()))
		{
			facef383_.method_9(null);
			if (flag)
			{
				throw new InvalidCastException();
			}
		}
		class58_0.c73f45d8.method_0(uint_, facef383_);
		class58_0.c73f45d8.a85b6a89(uint_);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(uint_);
		enum0_0 = (Enum0)0;
	}
}
