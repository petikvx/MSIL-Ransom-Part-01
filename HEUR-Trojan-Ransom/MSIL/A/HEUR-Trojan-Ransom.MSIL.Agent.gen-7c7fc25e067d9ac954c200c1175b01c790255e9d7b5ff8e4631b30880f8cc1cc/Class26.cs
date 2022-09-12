using System.Runtime.CompilerServices;

internal class Class26 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_14;
	}

	public unsafe void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint uint_ = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(uint_);
		feeb32c3 feeb32c3_;
		if (feeb32c4.cc3408c2() is Interface2)
		{
			feeb32c3_ = ((Interface2)feeb32c4.cc3408c2()).imethod_0(class54_0, (Enum1)0);
		}
		else
		{
			byte* ptr = (byte*)feeb32c4.d9a53946();
			feeb32c3 feeb32c5 = default(feeb32c3);
			feeb32c5.e885eacb(*ptr);
			feeb32c3_ = feeb32c5;
		}
		class54_0.class55_0.method_0(uint_, feeb32c3_);
		a0aa499b_0 = (a0aa499b)0;
	}
}
