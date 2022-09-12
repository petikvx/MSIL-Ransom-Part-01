using System.Runtime.CompilerServices;

internal class Class44 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.a0a01f42;
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
			((Interface2)feeb32c4.cc3408c2()).edfcdc20(class54_0, feeb32c3_, (Enum1)0);
		}
		else
		{
			byte b = feeb32c3_.f939861c();
			byte* ptr = (byte*)feeb32c4.d9a53946();
			*ptr = b;
		}
		a0aa499b_0 = (a0aa499b)0;
	}
}
