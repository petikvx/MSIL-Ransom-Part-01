using System.Runtime.CompilerServices;

internal class Class47 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.dd19c85f;
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
			((Interface1)@struct.c9550f69()).ce1637af(fdc40966_0, struct3_, Class0.bool_0 ? ((f75d8d37)3) : ((f75d8d37)2));
		}
		else if (Class0.bool_0)
		{
			ulong* ptr = (ulong*)@struct.ba535d1d();
			*ptr = struct3_.ba535d1d();
		}
		else
		{
			uint* ptr2 = (uint*)@struct.ba535d1d();
			*ptr2 = struct3_.method_1();
		}
		enum0_0 = (Enum0)0;
	}
}
