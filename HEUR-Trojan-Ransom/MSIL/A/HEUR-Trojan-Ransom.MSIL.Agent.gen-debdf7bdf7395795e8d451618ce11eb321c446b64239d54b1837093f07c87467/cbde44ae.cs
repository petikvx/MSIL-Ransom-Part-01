using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class cbde44ae : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.fbdb3bd4;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(num--);
		Struct2 struct2 = class49_0.ec45936d.a59d7f30(num);
		bool flag = (@struct.method_2() & 0x80000000u) != 0;
		FieldInfo fieldInfo = (FieldInfo)class49_0.class2_0.c73a3276().a9b0159f(@struct.method_2() & 0x7FFFFFFFu);
		if (!fieldInfo.IsStatic && struct2.method_6() == null)
		{
			throw new NullReferenceException();
		}
		if (flag)
		{
			a5c16fd5 ec45936d = class49_0.ec45936d;
			uint uint_ = num;
			Struct2 struct2_ = default(Struct2);
			struct2_.method_7(new Class47(struct2.method_6(), fieldInfo));
			ec45936d.d1cb88cf(uint_, struct2_);
		}
		else
		{
			object obj = ((!fieldInfo.DeclaringType!.IsValueType || !(struct2.method_6() is da5e0024)) ? struct2.method_8(fieldInfo.DeclaringType) : ((da5e0024)struct2.method_6()).imethod_0(class49_0, (Enum2)4).method_8(fieldInfo.DeclaringType));
			class49_0.ec45936d.d1cb88cf(num, Struct2.a5dd3349(fieldInfo.GetValue(obj), fieldInfo.FieldType));
		}
		class49_0.ec45936d.method_0(num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		enum1_0 = (Enum1)0;
	}
}
