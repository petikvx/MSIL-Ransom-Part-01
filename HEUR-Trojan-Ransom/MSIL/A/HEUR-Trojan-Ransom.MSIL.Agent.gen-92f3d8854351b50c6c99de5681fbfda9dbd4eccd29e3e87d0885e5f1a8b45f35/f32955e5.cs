using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class f32955e5 : d88be11e
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_68;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint num = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(num--);
		facef383 facef385 = class58_0.c73f45d8.a9bb6dff(num);
		bool flag = (facef384.df1ed028() & 0x80000000u) != 0;
		FieldInfo fieldInfo = (FieldInfo)class58_0.a3d704e3.method_0().method_2(facef384.df1ed028() & 0x7FFFFFFFu);
		if (!fieldInfo.IsStatic && facef385.method_8() == null)
		{
			throw new NullReferenceException();
		}
		if (flag)
		{
			Class59 c73f45d = class58_0.c73f45d8;
			uint uint_ = num;
			facef383 facef383_ = default(facef383);
			facef383_.method_9(new Class55(facef385.method_8(), fieldInfo));
			c73f45d.method_0(uint_, facef383_);
		}
		else
		{
			object obj = ((!fieldInfo.DeclaringType!.IsValueType || !(facef385.method_8() is Interface0)) ? facef385.f3c5123d(fieldInfo.DeclaringType) : ((Interface0)facef385.method_8()).b3037b45(class58_0, (Enum1)4).f3c5123d(fieldInfo.DeclaringType));
			class58_0.c73f45d8.method_0(num, facef383.b3e8ed04(fieldInfo.GetValue(obj), fieldInfo.FieldType));
		}
		class58_0.c73f45d8.a85b6a89(num);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(num);
		enum0_0 = (Enum0)0;
	}
}
