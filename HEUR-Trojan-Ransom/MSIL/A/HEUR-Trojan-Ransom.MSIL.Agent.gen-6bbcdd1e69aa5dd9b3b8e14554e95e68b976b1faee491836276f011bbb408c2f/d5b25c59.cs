using System.Runtime.CompilerServices;

internal class d5b25c59 : c955c655
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_58;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 struct3_ = fdc40966_0.class58_0.method_0(num--);
		Struct3 @struct = fdc40966_0.class58_0.method_0(num--);
		Struct3 struct2 = fdc40966_0.class58_0.method_0(num);
		struct3_.method_0(((long)struct3_.ba535d1d() > (long)@struct.ba535d1d() || (long)struct3_.ba535d1d() < (long)struct2.ba535d1d()) ? 1u : 0u);
		fdc40966_0.class58_0.b53f41f9(num, struct3_);
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		enum0_0 = (Enum0)0;
	}
}
