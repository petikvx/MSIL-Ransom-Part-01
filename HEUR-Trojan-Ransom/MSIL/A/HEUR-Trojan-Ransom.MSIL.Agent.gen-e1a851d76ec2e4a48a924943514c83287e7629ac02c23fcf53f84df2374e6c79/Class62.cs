using System.Collections.Generic;

internal class Class62
{
	public readonly ebd9b488[] ebd9b488_0 = new ebd9b488[16];

	public readonly Class64 class64_0 = new Class64();

	public readonly Class2 da79a168;

	public readonly List<Struct0> list_0 = new List<Struct0>();

	public readonly List<fc6ec998> dd0ec35b = new List<fc6ec998>();

	public Class62(Class2 class2_0)
	{
		da79a168 = class2_0;
	}

	public unsafe byte method_0()
	{
		uint num = ebd9b488_0[Class69.ac2dcb60].b585a11();
		ref ebd9b488 reference = ref ebd9b488_0[Class69.byte_5];
		ulong num2 = reference.method_0();
		reference.eca936fa(num2 + 1L);
		byte* ptr = (byte*)num2;
		byte b7500187 = (byte)(*ptr ^ num);
		num = num * 7 + b7500187;
		ebd9b488_0[Class69.ac2dcb60].cf774c3c(num);
		return b7500187;
	}
}
