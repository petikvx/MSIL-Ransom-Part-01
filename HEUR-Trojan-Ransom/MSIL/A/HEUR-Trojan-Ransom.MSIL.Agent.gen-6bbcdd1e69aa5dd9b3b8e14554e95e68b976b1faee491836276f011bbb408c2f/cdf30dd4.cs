using System.Runtime.CompilerServices;

internal class cdf30dd4 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_24;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		fdc40966_0.class58_0.method_1(++num);
		byte b = fdc40966_0.method_0();
		Struct3 @struct = fdc40966_0.struct3_0[b];
		if (b == fb3c043f.c55b5391 || b == fb3c043f.byte_5)
		{
			Class58 class58_ = fdc40966_0.class58_0;
			uint uint_ = num;
			Struct3 struct3_ = default(Struct3);
			struct3_.db2591b4(new dcd2092a(@struct.method_1()));
			class58_.b53f41f9(uint_, struct3_);
		}
		else
		{
			Class58 class58_2 = fdc40966_0.class58_0;
			uint uint_2 = num;
			Struct3 struct3_ = default(Struct3);
			struct3_.e63a4aca(@struct.method_1());
			class58_2.b53f41f9(uint_2, struct3_);
		}
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		enum0_0 = (Enum0)0;
	}
}
