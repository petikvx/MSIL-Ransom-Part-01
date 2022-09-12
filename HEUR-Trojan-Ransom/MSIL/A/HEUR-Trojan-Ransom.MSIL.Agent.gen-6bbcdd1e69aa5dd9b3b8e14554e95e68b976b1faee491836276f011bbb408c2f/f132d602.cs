using System;
using System.Runtime.CompilerServices;

internal class f132d602 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_52;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		ulong num2 = fdc40966_0.class58_0.method_0(num--).ba535d1d();
		int index = fdc40966_0.list_0.Count - 1;
		Struct0 @struct = fdc40966_0.list_0[index];
		if (@struct.ulong_1 != num2)
		{
			throw new InvalidProgramException();
		}
		fdc40966_0.list_0.RemoveAt(index);
		if (@struct.byte_0 == fb3c043f.cb102838)
		{
			fdc40966_0.class58_0.b53f41f9(++num, fdc40966_0.struct3_0[fb3c043f.ce86f7bc]);
			fdc40966_0.struct3_0[fb3c043f.byte_6].method_4(0);
			fdc40966_0.struct3_0[fb3c043f.ce86f7bc].method_0(@struct.ulong_1);
		}
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		enum0_0 = (Enum0)0;
	}
}
