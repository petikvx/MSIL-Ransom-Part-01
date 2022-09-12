using System.Runtime.CompilerServices;

internal class a37a9d79 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.bc2cafb;
	}

	public unsafe void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint uint_ = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(uint_);
		Struct3 struct3_;
		if (@struct.c9550f69() is Interface1)
		{
			struct3_ = ((Interface1)@struct.c9550f69()).bb331190(fdc40966_0, (f75d8d37)0);
		}
		else
		{
			byte* ptr = (byte*)@struct.ba535d1d();
			Struct3 struct2 = default(Struct3);
			struct2.method_4(*ptr);
			struct3_ = struct2;
		}
		fdc40966_0.class58_0.b53f41f9(uint_, struct3_);
		enum0_0 = (Enum0)0;
	}
}
