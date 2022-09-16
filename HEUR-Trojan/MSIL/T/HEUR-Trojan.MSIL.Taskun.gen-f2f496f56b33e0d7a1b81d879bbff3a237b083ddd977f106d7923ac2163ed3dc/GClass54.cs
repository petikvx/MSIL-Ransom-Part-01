using System;

public sealed class GClass54 : GClass9
{
	public GClass54(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		string_2 = Class16.smethod_0(-561800713);
	}

	public override void vmethod_26(ref int int_22, ref GClass91 gclass91_1)
	{
		int_22 = checked((int)Math.Round(Math.Max(int_22, Class24.smethod_1(gclass91_1.method_1(5), 2.0))));
		gclass91_1.method_5(Class16.smethod_0(-561801202) + vmethod_4() + Class16.smethod_0(-561805956));
		method_17(1);
	}
}
