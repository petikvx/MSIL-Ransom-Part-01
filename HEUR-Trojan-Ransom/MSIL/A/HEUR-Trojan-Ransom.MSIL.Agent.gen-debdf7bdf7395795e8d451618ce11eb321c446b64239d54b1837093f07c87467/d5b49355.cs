using System.Runtime.CompilerServices;

internal class d5b49355 : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.feae240c;
	}

	public unsafe void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(num);
		Struct2 struct2 = class49_0.ec45936d.a59d7f30(num - 1);
		num -= 2;
		class49_0.ec45936d.method_0(num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		uint num2 = struct2.method_2();
		ushort num3 = *(ushort*)(@struct.method_0() - 2L);
		if (num2 < num3)
		{
			ref Struct2 reference = ref class49_0.struct2_0[cb1fcba5.byte_9];
			reference.method_1(reference.method_0() + (ulong)(*(int*)((nint)@struct.method_0() + (nint)((long)num2 * 4L))));
		}
		enum1_0 = (Enum1)0;
	}
}
