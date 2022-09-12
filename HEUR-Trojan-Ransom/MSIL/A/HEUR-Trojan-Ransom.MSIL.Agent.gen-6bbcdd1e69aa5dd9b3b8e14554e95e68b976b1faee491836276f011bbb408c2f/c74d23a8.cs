using System.Runtime.CompilerServices;

internal class c74d23a8 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.b72e5f98;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint uint_ = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 struct3_ = fdc40966_0.class58_0.method_0(uint_);
		byte b = fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_3();
		if ((b & fb3c043f.byte_12) != 0)
		{
			struct3_.method_5(struct3_.ba535d1d());
		}
		else
		{
			struct3_.method_5((long)struct3_.ba535d1d());
		}
		fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_4((byte)(b & ~fb3c043f.byte_12));
		fdc40966_0.class58_0.b53f41f9(uint_, struct3_);
		enum0_0 = (Enum0)0;
	}
}
