using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class dc897e92 : bae6a63f
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_57;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(num--);
		ebd9b488 ebd9b490 = class62_0.class64_0.method_0(num);
		bool flag = (ebd9b489.b585a11() & 0x80000000u) != 0;
		FieldInfo fieldInfo = (FieldInfo)class62_0.da79a168.de5d16da().method_3(ebd9b489.b585a11() & 0x7FFFFFFFu);
		if (!fieldInfo.IsStatic && ebd9b490.ec0d6773() == null)
		{
			throw new NullReferenceException();
		}
		if (flag)
		{
			Class64 class64_ = class62_0.class64_0;
			uint uint_ = num;
			ebd9b488 ebd9b488_ = default(ebd9b488);
			ebd9b488_.aa900636(new Class59(ebd9b490.ec0d6773(), fieldInfo));
			class64_.method_1(uint_, ebd9b488_);
		}
		else
		{
			object obj = ((!fieldInfo.DeclaringType!.IsValueType || !(ebd9b490.ec0d6773() is Interface1)) ? ebd9b490.method_5(fieldInfo.DeclaringType) : ((Interface1)ebd9b490.ec0d6773()).imethod_0(class62_0, (Enum2)4).method_5(fieldInfo.DeclaringType));
			class62_0.class64_0.method_1(num, ebd9b488.e37ec81d(fieldInfo.GetValue(obj), fieldInfo.FieldType));
		}
		class62_0.class64_0.method_2(num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		enum1_0 = (Enum1)0;
	}
}
