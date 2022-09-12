using System.Runtime.CompilerServices;

internal class fef08c69 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.a0b083c4;
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
			((Interface2)feeb32c4.cc3408c2()).edfcdc20(class54_0, feeb32c3_, (Enum1)2);
		}
		else
		{
			uint num2 = feeb32c3_.method_0();
			uint* ptr = (uint*)feeb32c4.d9a53946();
			*ptr = num2;
		}
		a0aa499b_0 = (a0aa499b)0;
	}
}
