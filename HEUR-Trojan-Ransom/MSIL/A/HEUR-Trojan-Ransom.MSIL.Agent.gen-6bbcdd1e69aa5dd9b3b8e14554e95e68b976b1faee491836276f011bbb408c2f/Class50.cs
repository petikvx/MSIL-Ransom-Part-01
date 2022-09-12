using System.Runtime.CompilerServices;

internal class Class50 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_28;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint uint_ = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 struct3_ = fdc40966_0.class58_0.method_0(uint_);
		if ((struct3_.method_1() & 0x80000000u) != 0)
		{
			struct3_.method_0(0xFFFFFFFF00000000uL | struct3_.method_1());
		}
		fdc40966_0.class58_0.b53f41f9(uint_, struct3_);
		enum0_0 = (Enum0)0;
	}
}
