using System;
using System.Runtime.CompilerServices;

internal class Class52 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.cb57a04c;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		byte b = fdc40966_0.class58_0.method_0(num--).method_3();
		Struct0 item = default(Struct0);
		item.byte_0 = b;
		if (b == fb3c043f.byte_73)
		{
			item.type_0 = (Type)fdc40966_0.class2_0.method_0().method_3(fdc40966_0.class58_0.method_0(num--).method_1());
		}
		else if (b == fb3c043f.cae89496)
		{
			item.ulong_0 = fdc40966_0.class58_0.method_0(num--).ba535d1d();
		}
		item.ulong_1 = fdc40966_0.class58_0.method_0(num--).ba535d1d();
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		item.b7299474 = fdc40966_0.struct3_0[fb3c043f.byte_5];
		item.struct3_0 = fdc40966_0.struct3_0[fb3c043f.c55b5391];
		fdc40966_0.list_0.Add(item);
		enum0_0 = (Enum0)0;
	}
}
