using System.Runtime.CompilerServices;

internal class Class41 : df7d42ac
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_29;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint num = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		class58_0.c73f45d8.a85b6a89(++num);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(num);
		ulong num2 = class58_0.method_0();
		num2 |= (ulong)class58_0.method_0() << 8;
		num2 |= (ulong)class58_0.method_0() << 16;
		num2 |= (ulong)class58_0.method_0() << 24;
		ulong num3 = (((num2 & 0x80000000L) != 0L) ? 18446744069414584320uL : 0uL);
		Class59 c73f45d = class58_0.c73f45d8;
		uint uint_ = num;
		facef383 facef383_ = default(facef383);
		facef383_.method_1(num3 | num2);
		c73f45d.method_0(uint_, facef383_);
		enum0_0 = (Enum0)0;
	}
}
