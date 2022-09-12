using System;
using System.Runtime.CompilerServices;

internal class Class30 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_50;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ulong num2 = class62_0.class64_0.method_0(num--).method_0();
		int index = class62_0.list_0.Count - 1;
		Struct0 @struct = class62_0.list_0[index];
		if (@struct.ulong_1 != num2)
		{
			throw new InvalidProgramException();
		}
		class62_0.list_0.RemoveAt(index);
		if (@struct.byte_0 == Class69.byte_66)
		{
			class62_0.class64_0.method_1(++num, class62_0.ebd9b488_0[Class69.byte_5]);
			class62_0.ebd9b488_0[Class69.ac2dcb60].f7b1a530(0);
			class62_0.ebd9b488_0[Class69.byte_5].eca936fa(@struct.ulong_1);
		}
		class62_0.class64_0.method_2(num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		enum1_0 = (Enum1)0;
	}
}
