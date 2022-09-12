using System;
using System.Runtime.CompilerServices;

internal class Class50 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_58;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		byte b = class54_0.class55_0.ff4c393f(num--).f939861c();
		eec46a6e item = default(eec46a6e);
		item.byte_0 = b;
		if (b == c34ccaf0.af95d654)
		{
			item.type_0 = (Type)class54_0.class1_0.method_0().method_2(class54_0.class55_0.ff4c393f(num--).method_0());
		}
		else if (b == c34ccaf0.c8a44da3)
		{
			item.a749f3d0 = class54_0.class55_0.ff4c393f(num--).d9a53946();
		}
		item.ulong_0 = class54_0.class55_0.ff4c393f(num--).d9a53946();
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		item.c9adfef9 = class54_0.feeb32c3_0[c34ccaf0.d51d7317];
		item.b42d1c04 = class54_0.feeb32c3_0[c34ccaf0.byte_3];
		class54_0.d6265297.Add(item);
		a0aa499b_0 = (a0aa499b)0;
	}
}
