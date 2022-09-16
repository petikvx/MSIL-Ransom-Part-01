using System;

public sealed class GClass23 : GClass9
{
	public GClass23(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		string_2 = Class16.smethod_0(-561834361);
	}

	public override void vmethod_26(ref int int_22, ref GClass91 gclass91_1)
	{
		if (gclass91_1.method_1(7) >= 10 && Class24.smethod_0(1, 100) <= 30)
		{
			int_22 = checked(Math.Min(int_22 + gclass91_1.method_1(7), gclass91_1.method_1(5) + gclass91_1.method_1(7)));
			gclass91_1.method_5(Class16.smethod_0(-561834335) + vmethod_4() + Class16.smethod_0(-561805956));
			method_17(1);
		}
	}
}
