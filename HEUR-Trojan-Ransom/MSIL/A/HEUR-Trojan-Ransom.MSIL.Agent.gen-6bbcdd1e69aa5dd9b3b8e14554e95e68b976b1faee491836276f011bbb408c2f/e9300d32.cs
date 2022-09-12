using System.Runtime.CompilerServices;

internal class e9300d32 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_33;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num - 1);
		Struct3 struct2 = fdc40966_0.class58_0.method_0(num);
		num -= 2;
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		int num2 = ((@struct.c9550f69() != struct2.c9550f69()) ? (-1) : 0);
		byte b = (byte)(fb3c043f.aedb4ee4 | fb3c043f.byte_11 | fb3c043f.byte_9 | fb3c043f.byte_10);
		byte b2 = (byte)(fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_3() & ~b);
		if (num2 == 0)
		{
			b2 = (byte)(b2 | fb3c043f.aedb4ee4);
		}
		else if (num2 < 0)
		{
			b2 = (byte)(b2 | fb3c043f.byte_11);
		}
		fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_4(b2);
		enum0_0 = (Enum0)0;
	}
}
