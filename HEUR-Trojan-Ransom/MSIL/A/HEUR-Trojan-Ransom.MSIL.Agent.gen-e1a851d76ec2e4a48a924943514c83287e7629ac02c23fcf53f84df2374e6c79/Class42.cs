using System.Runtime.CompilerServices;

internal class Class42 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.b79127e5;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		class62_0.class64_0.method_2(++num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		ulong num2 = class62_0.method_0();
		num2 |= (ulong)class62_0.method_0() << 8;
		num2 |= (ulong)class62_0.method_0() << 16;
		num2 |= (ulong)class62_0.method_0() << 24;
		ulong num3 = (((num2 & 0x80000000L) != 0L) ? 18446744069414584320uL : 0uL);
		Class64 class64_ = class62_0.class64_0;
		uint uint_ = num;
		ebd9b488 ebd9b488_ = default(ebd9b488);
		ebd9b488_.eca936fa(num3 | num2);
		class64_.method_1(uint_, ebd9b488_);
		enum1_0 = (Enum1)0;
	}
}
