using System.Runtime.CompilerServices;

internal class Class25 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.f5755d6b;
	}

	public unsafe void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num);
		feeb32c3 feeb32c5 = class54_0.class55_0.ff4c393f(num - 1);
		num -= 2;
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		uint num2 = feeb32c5.method_0();
		ushort num3 = *(ushort*)(feeb32c4.d9a53946() - 2L);
		if (num2 < num3)
		{
			ref feeb32c3 reference = ref class54_0.feeb32c3_0[c34ccaf0.cb256761];
			reference.b67abfed(reference.d9a53946() + (ulong)(*(int*)((nint)feeb32c4.d9a53946() + (nint)((long)num2 * 4L))));
		}
		a0aa499b_0 = (a0aa499b)0;
	}
}
