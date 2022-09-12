using System.Runtime.CompilerServices;

internal class Class33 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_39;
	}

	private static ulong smethod_0(ulong ulong_0, ulong ulong_1)
	{
		ulong num = ulong_0 & 0xFFFFFFFFuL;
		ulong num2 = ulong_0 >> 32;
		ulong num3 = ulong_1 & 0xFFFFFFFFuL;
		ulong num4 = ulong_1 >> 32;
		ulong num5 = num * num3;
		num5 = num2 * num3 + (num5 >> 32);
		ulong num6 = num5 & 0xFFFFFFFFuL;
		ulong num7 = num5 >> 32;
		num5 = num6 + num * num4;
		num6 = num5 & 0xFFFFFFFFuL;
		return num7 + num2 * num4 + (num5 >> 32);
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num - 1);
		Struct3 struct2 = fdc40966_0.class58_0.method_0(num);
		num--;
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		byte b = fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_3();
		Struct3 struct3_ = default(Struct3);
		ulong num2 = @struct.ba535d1d() * struct2.ba535d1d();
		struct3_.method_0(num2);
		fdc40966_0.class58_0.b53f41f9(num, struct3_);
		byte byte_ = (byte)(fb3c043f.aedb4ee4 | fb3c043f.byte_11 | fb3c043f.byte_12);
		byte b2 = (byte)(fb3c043f.byte_10 | fb3c043f.byte_9);
		byte b3 = 0;
		if ((b & fb3c043f.byte_12) != 0)
		{
			if (smethod_0(@struct.ba535d1d(), struct2.ba535d1d()) > 0L)
			{
				b3 = b2;
			}
		}
		else if (num2 >> 63 != (@struct.ba535d1d() ^ struct2.ba535d1d()) >> 63)
		{
			b3 = b2;
		}
		b = (byte)((b & ~b2) | b3);
		Class1.smethod_2(@struct.method_1(), struct2.ba535d1d(), struct3_.ba535d1d(), struct3_.ba535d1d(), ref b, byte_);
		fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_4(b);
		enum0_0 = (Enum0)0;
	}
}
