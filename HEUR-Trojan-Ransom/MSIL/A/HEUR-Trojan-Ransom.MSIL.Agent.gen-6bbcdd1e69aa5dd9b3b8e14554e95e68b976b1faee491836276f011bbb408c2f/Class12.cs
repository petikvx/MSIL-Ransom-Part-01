using System.Runtime.CompilerServices;

internal class Class12 : c955c655
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_62;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint uint_ = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		uint num = fdc40966_0.class58_0.method_0(uint_--).method_1();
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(uint_);
		if (num == 1)
		{
			enum0_0 = (Enum0)3;
		}
		else
		{
			enum0_0 = (Enum0)2;
		}
	}
}
