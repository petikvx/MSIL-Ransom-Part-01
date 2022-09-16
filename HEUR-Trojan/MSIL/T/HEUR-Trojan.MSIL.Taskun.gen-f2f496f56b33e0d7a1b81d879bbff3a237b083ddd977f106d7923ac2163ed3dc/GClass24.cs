using System;

public sealed class GClass24 : GClass9
{
	public GClass24(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		string_2 = Class16.smethod_0(-561791265);
	}

	public override void vmethod_14(ref GClass91 gclass91_1)
	{
		base.vmethod_14(ref gclass91_1);
		if (gclass91_1.method_1(7) > 10)
		{
			int num = 1;
			num = checked((int)Math.Round(1.0 + Class24.smethod_1(gclass91_1.method_1(7), 20.0)));
			if (Class24.smethod_0(1, 10) <= num)
			{
				gclass91_1.method_0(7, 0);
				gclass91_1.method_0(5, 0);
				gclass91_1.method_5(Class16.smethod_0(-561791235));
				method_17(1);
			}
		}
	}
}
