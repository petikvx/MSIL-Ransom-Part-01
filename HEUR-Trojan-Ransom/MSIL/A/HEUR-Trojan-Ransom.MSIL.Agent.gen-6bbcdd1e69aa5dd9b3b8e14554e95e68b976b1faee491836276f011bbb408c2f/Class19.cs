using System.Runtime.CompilerServices;

internal class Class19 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_34;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num - 1);
		Struct3 struct2 = fdc40966_0.class58_0.method_0(num);
		num -= 2;
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		uint num2 = @struct.method_1() - struct2.method_1();
		byte byte_ = (byte)(fb3c043f.aedb4ee4 | fb3c043f.byte_11 | fb3c043f.byte_9 | fb3c043f.byte_10);
		byte byte_2 = fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_3();
		Class1.smethod_1(num2, struct2.method_1(), @struct.method_1(), num2, ref byte_2, byte_);
		fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_4(byte_2);
		enum0_0 = (Enum0)0;
	}
}
