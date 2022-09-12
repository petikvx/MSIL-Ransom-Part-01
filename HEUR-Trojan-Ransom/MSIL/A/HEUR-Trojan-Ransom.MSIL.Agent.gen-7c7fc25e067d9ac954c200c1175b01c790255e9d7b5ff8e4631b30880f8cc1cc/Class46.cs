using System.Runtime.CompilerServices;

internal class Class46 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_17;
	}

	public unsafe void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num--);
		feeb32c3 feeb32c3_ = class54_0.class55_0.ff4c393f(num--);
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		if (feeb32c4.cc3408c2() is Interface2)
		{
			((Interface2)feeb32c4.cc3408c2()).edfcdc20(class54_0, feeb32c3_, Class0.bool_0 ? ((Enum1)3) : ((Enum1)2));
		}
		else if (Class0.bool_0)
		{
			ulong* ptr = (ulong*)feeb32c4.d9a53946();
			*ptr = feeb32c3_.d9a53946();
		}
		else
		{
			uint* ptr2 = (uint*)feeb32c4.d9a53946();
			*ptr2 = feeb32c3_.method_0();
		}
		a0aa499b_0 = (a0aa499b)0;
	}
}
