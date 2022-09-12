using System;
using System.Runtime.CompilerServices;

internal class ab9dc8bf : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_59;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		ulong num2 = class54_0.class55_0.ff4c393f(num--).d9a53946();
		int index = class54_0.d6265297.Count - 1;
		eec46a6e eec46a6e2 = class54_0.d6265297[index];
		if (eec46a6e2.ulong_0 != num2)
		{
			throw new InvalidProgramException();
		}
		class54_0.d6265297.RemoveAt(index);
		if (eec46a6e2.byte_0 == c34ccaf0.byte_74)
		{
			class54_0.class55_0.method_0(++num, class54_0.feeb32c3_0[c34ccaf0.cb256761]);
			class54_0.feeb32c3_0[c34ccaf0.byte_5].e885eacb(0);
			class54_0.feeb32c3_0[c34ccaf0.cb256761].b67abfed(eec46a6e2.ulong_0);
		}
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		a0aa499b_0 = (a0aa499b)0;
	}
}
