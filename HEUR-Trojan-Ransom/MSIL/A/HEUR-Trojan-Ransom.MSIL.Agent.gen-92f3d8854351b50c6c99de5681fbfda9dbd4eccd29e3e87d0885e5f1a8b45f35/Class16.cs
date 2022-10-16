using System.Runtime.CompilerServices;

internal class Class16 : df7d42ac
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.e167b126;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint num = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(num - 1);
		facef383 facef385 = class58_0.c73f45d8.a9bb6dff(num);
		num -= 2;
		class58_0.c73f45d8.a85b6a89(num);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(num);
		uint num2 = facef384.df1ed028() - facef385.df1ed028();
		byte byte_ = (byte)(b13312b0.d805a5e9 | b13312b0.a8943634 | b13312b0.byte_11 | b13312b0.ad16d432);
		byte byte_2 = class58_0.a6890f1d[b13312b0.a048350c].a42951dc();
		Class1.smethod_0(num2, facef385.df1ed028(), facef384.df1ed028(), num2, ref byte_2, byte_);
		class58_0.a6890f1d[b13312b0.a048350c].method_4(byte_2);
		enum0_0 = (Enum0)0;
	}
}
