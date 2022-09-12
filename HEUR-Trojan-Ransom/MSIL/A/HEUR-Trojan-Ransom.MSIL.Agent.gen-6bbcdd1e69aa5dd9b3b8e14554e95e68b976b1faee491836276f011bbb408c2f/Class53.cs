using System.Runtime.CompilerServices;

internal class Class53 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_51;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num);
		fdc40966_0.class58_0.method_1(--num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		c955c655 c955c656 = Class64.f7aed62a(@struct.method_3());
		c955c656.imethod_1(fdc40966_0, out enum0_0);
	}
}
