using System.Runtime.CompilerServices;

internal class abd1c68b : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_57;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num);
		class54_0.class55_0.method_1(--num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		Interface0 @interface = Class63.ff226187(feeb32c4.f939861c());
		@interface.imethod_1(class54_0, out a0aa499b_0);
	}
}
