using System;
using System.Runtime.CompilerServices;

internal class Class5 : c955c655
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_56;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num--);
		byte b = fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_3();
		if ((b & fb3c043f.byte_12) != 0)
		{
			float f5784722 = @struct.method_6();
			if (float.IsNaN(f5784722) || float.IsInfinity(f5784722))
			{
				throw new ArithmeticException();
			}
		}
		else
		{
			double d = @struct.ff1d6065();
			if (double.IsNaN(d) || double.IsInfinity(d))
			{
				throw new ArithmeticException();
			}
		}
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		enum0_0 = (Enum0)0;
	}
}
