using System.Runtime.CompilerServices;

internal class dcf71775 : df7d42ac
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_37;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint num = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(num - 1);
		facef383 facef385 = class58_0.c73f45d8.a9bb6dff(num);
		num -= 2;
		class58_0.c73f45d8.a85b6a89(num);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(num);
		float num2 = facef384.method_6() - facef385.method_6();
		byte b = (byte)(b13312b0.d805a5e9 | b13312b0.a8943634 | b13312b0.byte_11 | b13312b0.ad16d432);
		byte b2 = (byte)(class58_0.a6890f1d[b13312b0.a048350c].a42951dc() & ~b);
		if (num2 == 0f)
		{
			b2 = (byte)(b2 | b13312b0.d805a5e9);
		}
		else if (num2 < 0f)
		{
			b2 = (byte)(b2 | b13312b0.a8943634);
		}
		class58_0.a6890f1d[b13312b0.a048350c].method_4(b2);
		enum0_0 = (Enum0)0;
	}
}
