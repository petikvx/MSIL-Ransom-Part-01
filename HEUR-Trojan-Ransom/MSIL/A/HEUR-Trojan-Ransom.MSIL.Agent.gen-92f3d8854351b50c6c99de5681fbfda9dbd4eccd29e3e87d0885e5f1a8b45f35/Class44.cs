using System.Runtime.CompilerServices;

internal class Class44 : df7d42ac
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.a90fc40;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint num = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(num - 1);
		facef383 facef385 = class58_0.c73f45d8.a9bb6dff(num);
		num--;
		class58_0.c73f45d8.a85b6a89(num);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(num);
		byte byte_ = class58_0.a6890f1d[b13312b0.a048350c].a42951dc();
		facef383 facef383_ = default(facef383);
		if ((byte_ & b13312b0.byte_12) != 0)
		{
			facef383_.method_2(facef384.df1ed028() >> (int)facef385.df1ed028());
		}
		else
		{
			facef383_.method_2((uint)((int)facef384.df1ed028() >> (int)facef385.df1ed028()));
		}
		class58_0.c73f45d8.method_0(num, facef383_);
		byte byte_2 = (byte)(b13312b0.d805a5e9 | b13312b0.a8943634 | b13312b0.byte_12);
		Class1.smethod_0(facef384.df1ed028(), facef385.df1ed028(), facef383_.df1ed028(), facef383_.df1ed028(), ref byte_, byte_2);
		class58_0.a6890f1d[b13312b0.a048350c].method_4(byte_);
		enum0_0 = (Enum0)0;
	}
}
