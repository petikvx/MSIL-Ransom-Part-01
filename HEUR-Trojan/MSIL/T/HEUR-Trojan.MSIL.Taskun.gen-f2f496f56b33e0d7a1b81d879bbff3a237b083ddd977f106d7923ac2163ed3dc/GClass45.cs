using System;

public sealed class GClass45 : GClass9
{
	public GClass45(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		string_2 = Class16.smethod_0(-561834001);
	}

	public override void vmethod_14(ref GClass91 gclass91_1)
	{
		base.vmethod_14(ref gclass91_1);
		checked
		{
			if (gclass91_1.method_1(6) > 10)
			{
				int num = 1;
				num = (int)Math.Round(1.0 + Class24.smethod_1(gclass91_1.method_1(6), 10.0));
				if (Class24.smethod_0(1, 10) <= num)
				{
					gclass91_1.method_0(6, 0);
					gclass91_1.method_0(5, (int)Math.Round(Class24.smethod_1(gclass91_1.method_1(5), 2.0)));
					gclass91_1.method_5(Class16.smethod_0(-561791235));
					method_17(1);
				}
			}
		}
	}
}
