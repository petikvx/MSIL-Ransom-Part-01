using System.Runtime.CompilerServices;

internal class Class33 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_23;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		class54_0.class55_0.method_1(++num);
		byte b = class54_0.method_0();
		feeb32c3 feeb32c4 = class54_0.feeb32c3_0[b];
		if (b == c34ccaf0.byte_3 || b == c34ccaf0.d51d7317)
		{
			Class55 class55_ = class54_0.class55_0;
			uint uint_ = num;
			feeb32c3 feeb32c3_ = default(feeb32c3);
			feeb32c3_.method_7(new d6c76087(feeb32c4.method_0()));
			class55_.method_0(uint_, feeb32c3_);
		}
		else
		{
			Class55 class55_2 = class54_0.class55_0;
			uint uint_2 = num;
			feeb32c3 feeb32c3_ = default(feeb32c3);
			feeb32c3_.method_1(feeb32c4.method_0());
			class55_2.method_0(uint_2, feeb32c3_);
		}
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		a0aa499b_0 = (a0aa499b)0;
	}
}
