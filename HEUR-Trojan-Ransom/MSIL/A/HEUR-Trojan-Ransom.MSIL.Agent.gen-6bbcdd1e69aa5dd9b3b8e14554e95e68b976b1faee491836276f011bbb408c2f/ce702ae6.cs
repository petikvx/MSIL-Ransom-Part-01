using System;
using System.Runtime.CompilerServices;

internal class ce702ae6 : c955c655
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_57;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		if (fdc40966_0.class58_0.method_0(num--).method_1() != 0)
		{
			throw new OverflowException();
		}
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		enum0_0 = (Enum0)0;
	}
}
