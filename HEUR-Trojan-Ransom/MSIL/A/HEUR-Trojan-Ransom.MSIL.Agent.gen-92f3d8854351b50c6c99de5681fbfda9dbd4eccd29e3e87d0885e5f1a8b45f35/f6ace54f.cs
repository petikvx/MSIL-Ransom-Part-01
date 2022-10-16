using System;
using System.Runtime.CompilerServices;

internal class f6ace54f : d88be11e
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.d3756181;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint uint_ = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(uint_--);
		facef383 facef383_ = class58_0.c73f45d8.a9bb6dff(uint_);
		Type type = (Type)class58_0.a3d704e3.method_0().method_2(facef384.df1ed028());
		if (Type.GetTypeCode(type) == TypeCode.String && facef383_.method_8() == null)
		{
			facef383_.method_9(class58_0.a3d704e3.method_0().method_3(facef383_.df1ed028()));
		}
		else
		{
			facef383_.method_9(facef383_.f3c5123d(type));
		}
		class58_0.c73f45d8.method_0(uint_, facef383_);
		class58_0.c73f45d8.a85b6a89(uint_);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(uint_);
		enum0_0 = (Enum0)0;
	}
}
