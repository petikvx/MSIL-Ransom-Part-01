using System.Runtime.CompilerServices;

internal class Class37 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_22;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		fdc40966_0.class58_0.method_1(++num);
		byte b = fdc40966_0.method_0();
		Struct3 @struct = fdc40966_0.struct3_0[b];
		Class58 class58_ = fdc40966_0.class58_0;
		uint uint_ = num;
		Struct3 struct3_ = default(Struct3);
		struct3_.method_4(@struct.method_3());
		class58_.b53f41f9(uint_, struct3_);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		enum0_0 = (Enum0)0;
	}
}
