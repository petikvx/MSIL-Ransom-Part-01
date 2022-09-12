using System.Runtime.CompilerServices;

internal class aeb3bb7f : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.a474592d;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num);
		fdc40966_0.class58_0.method_1(--num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		byte b = fdc40966_0.method_0();
		if ((b == fb3c043f.c55b5391 || b == fb3c043f.byte_5) && @struct.c9550f69() is dcd2092a)
		{
			Struct3[] struct3_ = fdc40966_0.struct3_0;
			Struct3 struct2 = default(Struct3);
			struct2.e63a4aca(((dcd2092a)@struct.c9550f69()).method_0());
			struct3_[b] = struct2;
		}
		else
		{
			fdc40966_0.struct3_0[b] = @struct;
		}
		enum0_0 = (Enum0)0;
	}
}
