using System.Runtime.CompilerServices;

internal class Class17 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_37;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num - 1);
		Struct3 struct2 = fdc40966_0.class58_0.method_0(num);
		num--;
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		Struct3 struct3_ = default(Struct3);
		struct3_.method_5(struct2.ff1d6065() + @struct.ff1d6065());
		fdc40966_0.class58_0.b53f41f9(num, struct3_);
		byte b = (byte)(fb3c043f.aedb4ee4 | fb3c043f.byte_11 | fb3c043f.byte_9 | fb3c043f.byte_10);
		byte b2 = (byte)(fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_3() & ~b);
		if (struct3_.ff1d6065() == 0.0)
		{
			b2 = (byte)(b2 | fb3c043f.aedb4ee4);
		}
		else if (struct3_.ff1d6065() < 0.0)
		{
			b2 = (byte)(b2 | fb3c043f.byte_11);
		}
		fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_4(b2);
		enum0_0 = (Enum0)0;
	}
}
