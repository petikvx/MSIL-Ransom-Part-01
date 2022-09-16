using System;
using System.Collections.Generic;

public sealed class GClass49 : GClass48
{
	public GClass49(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		double_0 = 5.0;
		double_1 = 7.5;
		string_2 = Class16.smethod_0(-561792601);
	}

	public override void vmethod_19(ref List<GClass9> list_3)
	{
		base.vmethod_19(ref list_3);
		if (Class24.smethod_0(1, 100) <= 3)
		{
			GClass9 gClass = Class24.gclass6_0.method_3(57);
			gClass.int_3 = vmethod_9();
			gclass97_0.method_22(gClass, int_10, bool_1: true);
			Class24.gclass90_0.gclass0_12.method_1(method_6() + Class16.smethod_0(-561792579) + gClass.vmethod_4());
			gClass.int_5 = Math.Max(gClass.int_5, checked(int_5 + 2));
			GClass9 gclass9_ = this;
			gClass.method_14(ref gclass9_);
			list_3.Add(this);
		}
	}
}
