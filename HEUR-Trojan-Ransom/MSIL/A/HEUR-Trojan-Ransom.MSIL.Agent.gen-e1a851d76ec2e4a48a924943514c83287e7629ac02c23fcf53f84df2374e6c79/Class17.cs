using System.Runtime.CompilerServices;

internal class Class17 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_30;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(num - 1);
		ebd9b488 ebd9b490 = class62_0.class64_0.method_0(num);
		num -= 2;
		class62_0.class64_0.method_2(num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		ulong num2 = ebd9b489.method_0() - ebd9b490.method_0();
		byte byte_ = (byte)(Class69.cf427ee6 | Class69.a5d5090d | Class69.byte_10 | Class69.bce0c6e3);
		byte byte_2 = class62_0.ebd9b488_0[Class69.byte_6].fc52add5();
		Class1.d4c25246(num2, ebd9b490.method_0(), ebd9b489.method_0(), num2, ref byte_2, byte_);
		class62_0.ebd9b488_0[Class69.byte_6].f7b1a530(byte_2);
		enum1_0 = (Enum1)0;
	}
}
