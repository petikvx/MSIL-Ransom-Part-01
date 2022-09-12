using System.Runtime.CompilerServices;

internal class Class27 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_36;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num);
		Struct3 struct2 = fdc40966_0.class58_0.method_0(num - 1);
		num -= 2;
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		if (struct2.ba535d1d() == 0L)
		{
			fdc40966_0.struct3_0[fb3c043f.ce86f7bc].method_0(@struct.ba535d1d());
		}
		enum0_0 = (Enum0)0;
	}
}
