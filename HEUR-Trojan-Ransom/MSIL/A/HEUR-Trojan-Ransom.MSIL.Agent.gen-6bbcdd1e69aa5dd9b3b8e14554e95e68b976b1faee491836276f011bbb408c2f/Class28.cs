using System.Runtime.CompilerServices;

internal class Class28 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.bb3adfbe;
	}

	public unsafe void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num);
		Struct3 struct2 = fdc40966_0.class58_0.method_0(num - 1);
		num -= 2;
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		uint num2 = struct2.method_1();
		ushort num3 = *(ushort*)(@struct.ba535d1d() - 2L);
		if (num2 < num3)
		{
			ref Struct3 reference = ref fdc40966_0.struct3_0[fb3c043f.ce86f7bc];
			reference.method_0(reference.ba535d1d() + (ulong)(*(int*)((nint)@struct.ba535d1d() + (nint)((long)num2 * 4L))));
		}
		enum0_0 = (Enum0)0;
	}
}
