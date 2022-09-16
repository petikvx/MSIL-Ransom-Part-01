using System.Collections.Generic;

public sealed class GClass73 : GClass9
{
	public GClass73(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
	}

	public override void vmethod_19(ref List<GClass9> list_3)
	{
		base.vmethod_19(ref list_3);
		if (Class24.smethod_0(1, 5) == 1)
		{
			GClass9 gClass = Class24.gclass6_0.method_3(-1);
			gClass.int_3 = vmethod_9();
			gclass97_0.method_22(gClass, int_10, bool_1: true);
			Class24.gclass90_0.gclass0_12.method_1(method_6() + Class16.smethod_0(-561791320) + gClass.vmethod_4());
			list_3.Add(this);
		}
	}
}
