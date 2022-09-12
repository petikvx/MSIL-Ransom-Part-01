using System.Runtime.CompilerServices;

internal class Class51 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.b1edde75;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint uint_ = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 struct3_ = fdc40966_0.class58_0.method_0(uint_);
		if ((struct3_.method_3() & 0x80u) != 0)
		{
			struct3_.e63a4aca(struct3_.method_3() | 0xFFFFFF00u);
		}
		fdc40966_0.class58_0.b53f41f9(uint_, struct3_);
		enum0_0 = (Enum0)0;
	}
}
