using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class8 : c955c655
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_59;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num--);
		Struct3 struct2 = fdc40966_0.class58_0.method_0(num);
		bool flag = (@struct.method_1() & 0x80000000u) != 0;
		FieldInfo fieldInfo = (FieldInfo)fdc40966_0.class2_0.method_0().method_3(@struct.method_1() & 0x7FFFFFFFu);
		if (!fieldInfo.IsStatic && struct2.c9550f69() == null)
		{
			throw new NullReferenceException();
		}
		if (flag)
		{
			Class58 class58_ = fdc40966_0.class58_0;
			uint uint_ = num;
			Struct3 struct3_ = default(Struct3);
			struct3_.db2591b4(new Class55(struct2.c9550f69(), fieldInfo));
			class58_.b53f41f9(uint_, struct3_);
		}
		else
		{
			object obj = ((!fieldInfo.DeclaringType!.IsValueType || !(struct2.c9550f69() is Interface1)) ? struct2.e3ce4628(fieldInfo.DeclaringType) : ((Interface1)struct2.c9550f69()).bb331190(fdc40966_0, (f75d8d37)4).e3ce4628(fieldInfo.DeclaringType));
			fdc40966_0.class58_0.b53f41f9(num, Struct3.smethod_0(fieldInfo.GetValue(obj), fieldInfo.FieldType));
		}
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		enum0_0 = (Enum0)0;
	}
}
