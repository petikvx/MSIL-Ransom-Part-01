using System.Runtime.CompilerServices;

internal class Class25 : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.c934490b;
	}

	public unsafe void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint num = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(num);
		Struct2 struct2 = class52_0.c6a36180_0.f113e6df(num - 1);
		num -= 2;
		class52_0.c6a36180_0.method_0(num);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(num);
		uint num2 = struct2.b5683088();
		ushort num3 = *(ushort*)(@struct.method_0() - 2L);
		if (num2 < num3)
		{
			ref Struct2 reference = ref class52_0.struct2_0[fae0f10.d1e82201];
			reference.f6b2288d(reference.method_0() + (ulong)(*(int*)((nint)@struct.method_0() + (nint)((long)num2 * 4L))));
		}
		a82ced3b_0 = (a82ced3b)0;
	}
}
