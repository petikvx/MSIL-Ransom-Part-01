using System.Runtime.CompilerServices;

internal class Class35 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_38;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(num - 1);
		ebd9b488 ebd9b490 = class62_0.class64_0.method_0(num);
		num--;
		class62_0.class64_0.method_2(num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		byte b7500187 = class62_0.ebd9b488_0[Class69.byte_6].fc52add5();
		ebd9b488 ebd9b488_ = default(ebd9b488);
		ulong num2 = ebd9b489.b585a11() * ebd9b490.b585a11();
		ebd9b488_.cf774c3c((uint)num2);
		class62_0.class64_0.method_1(num, ebd9b488_);
		byte byte_ = (byte)(Class69.cf427ee6 | Class69.a5d5090d | Class69.byte_11);
		byte b7500188 = (byte)(Class69.bce0c6e3 | Class69.byte_10);
		byte b7500189 = 0;
		if ((b7500187 & Class69.byte_11) != 0)
		{
			if ((num2 & 0xFFFFFFFFL) > 0L)
			{
				b7500189 = b7500188;
			}
		}
		else
		{
			num2 = (ulong)(int)(ebd9b489.b585a11() * ebd9b490.b585a11());
			if (num2 >> 63 != ebd9b488_.b585a11() >> 31)
			{
				b7500189 = b7500188;
			}
		}
		b7500187 = (byte)((b7500187 & ~b7500188) | b7500189);
		Class1.d4c25246(ebd9b489.b585a11(), ebd9b490.b585a11(), ebd9b488_.b585a11(), ebd9b488_.b585a11(), ref b7500187, byte_);
		class62_0.ebd9b488_0[Class69.byte_6].f7b1a530(b7500187);
		enum1_0 = (Enum1)0;
	}
}
