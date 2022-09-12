using System.Runtime.CompilerServices;

internal class c424b4d : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_26;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		fdc40966_0.class58_0.method_1(++num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		ulong num2 = fdc40966_0.method_0();
		num2 |= (ulong)fdc40966_0.method_0() << 8;
		num2 |= (ulong)fdc40966_0.method_0() << 16;
		num2 |= (ulong)fdc40966_0.method_0() << 24;
		ulong num3 = (((num2 & 0x80000000L) != 0L) ? 18446744069414584320uL : 0uL);
		Class58 class58_ = fdc40966_0.class58_0;
		uint uint_ = num;
		Struct3 struct3_ = default(Struct3);
		struct3_.method_0(num3 | num2);
		class58_.b53f41f9(uint_, struct3_);
		enum0_0 = (Enum0)0;
	}
}
