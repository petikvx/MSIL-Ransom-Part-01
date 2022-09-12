using System.Runtime.CompilerServices;

internal class d7ff47b1 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_49;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint uint_ = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 struct3_ = fdc40966_0.class58_0.method_0(uint_);
		byte b = (byte)(fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_3() & ~fb3c043f.byte_9);
		if (!Class0.bool_0 && struct3_.ba535d1d() >> 32 > 0L)
		{
			b = (byte)(b | fb3c043f.byte_9);
		}
		fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_4(b);
		fdc40966_0.class58_0.b53f41f9(uint_, struct3_);
		enum0_0 = (Enum0)0;
	}
}
