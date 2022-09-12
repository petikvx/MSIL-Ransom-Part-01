using System;
using System.Runtime.CompilerServices;

internal class ffa91f95 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_49;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		byte b7500187 = class62_0.class64_0.method_0(num--).fc52add5();
		Struct0 item = default(Struct0);
		item.byte_0 = b7500187;
		if (b7500187 == Class69.byte_64)
		{
			item.a85b1b33 = (Type)class62_0.da79a168.de5d16da().method_3(class62_0.class64_0.method_0(num--).b585a11());
		}
		else if (b7500187 == Class69.byte_65)
		{
			item.ulong_0 = class62_0.class64_0.method_0(num--).method_0();
		}
		item.ulong_1 = class62_0.class64_0.method_0(num--).method_0();
		class62_0.class64_0.method_2(num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		item.bde0a6f6 = class62_0.ebd9b488_0[Class69.ad8cd76c];
		item.b16371dd = class62_0.ebd9b488_0[Class69.byte_4];
		class62_0.list_0.Add(item);
		enum1_0 = (Enum1)0;
	}
}
