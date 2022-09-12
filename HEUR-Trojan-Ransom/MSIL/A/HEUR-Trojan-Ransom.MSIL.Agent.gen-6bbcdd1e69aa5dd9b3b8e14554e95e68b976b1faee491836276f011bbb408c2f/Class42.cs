using System.Runtime.CompilerServices;

internal class Class42 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_45;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num - 1);
		Struct3 struct2 = fdc40966_0.class58_0.method_0(num);
		num--;
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		byte byte_ = fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_3();
		Struct3 struct3_ = default(Struct3);
		if ((byte_ & fb3c043f.byte_12) != 0)
		{
			struct3_.e63a4aca(@struct.method_1() >> (int)struct2.method_1());
		}
		else
		{
			struct3_.e63a4aca((uint)((int)@struct.method_1() >> (int)struct2.method_1()));
		}
		fdc40966_0.class58_0.b53f41f9(num, struct3_);
		byte byte_2 = (byte)(fb3c043f.aedb4ee4 | fb3c043f.byte_11 | fb3c043f.byte_12);
		Class1.smethod_1(@struct.method_1(), struct2.method_1(), struct3_.method_1(), struct3_.method_1(), ref byte_, byte_2);
		fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_4(byte_);
		enum0_0 = (Enum0)0;
	}
}
