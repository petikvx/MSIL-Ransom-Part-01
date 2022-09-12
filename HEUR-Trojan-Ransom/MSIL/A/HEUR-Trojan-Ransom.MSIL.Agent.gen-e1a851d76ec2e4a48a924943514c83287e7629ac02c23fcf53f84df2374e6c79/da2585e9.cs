using System.Runtime.CompilerServices;

internal class da2585e9 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_34;
	}

	public unsafe void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(num);
		ebd9b488 ebd9b490 = class62_0.class64_0.method_0(num - 1);
		num -= 2;
		class62_0.class64_0.method_2(num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		uint num2 = ebd9b490.b585a11();
		ushort num3 = *(ushort*)(ebd9b489.method_0() - 2L);
		if (num2 < num3)
		{
			ref ebd9b488 reference = ref class62_0.ebd9b488_0[Class69.byte_5];
			reference.eca936fa(reference.method_0() + (ulong)(*(int*)((nint)ebd9b489.method_0() + (nint)((long)num2 * 4L))));
		}
		enum1_0 = (Enum1)0;
	}
}
