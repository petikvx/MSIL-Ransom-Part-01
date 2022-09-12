using System.Runtime.CompilerServices;

internal class c7c5c3a2 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.df1f93e9;
	}

	public unsafe void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num--);
		Struct3 struct3_ = fdc40966_0.class58_0.method_0(num--);
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		if (@struct.c9550f69() is Interface1)
		{
			((Interface1)@struct.c9550f69()).ce1637af(fdc40966_0, struct3_, (f75d8d37)0);
		}
		else
		{
			byte b = struct3_.method_3();
			byte* ptr = (byte*)@struct.ba535d1d();
			*ptr = b;
		}
		enum0_0 = (Enum0)0;
	}
}
