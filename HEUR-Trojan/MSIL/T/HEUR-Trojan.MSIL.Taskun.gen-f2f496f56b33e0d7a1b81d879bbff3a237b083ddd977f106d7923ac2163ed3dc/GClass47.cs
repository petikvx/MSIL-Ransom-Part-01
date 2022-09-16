using System;

public sealed class GClass47 : GClass9
{
	public int int_22;

	public GClass47(int int_23, int int_24, int int_25, int int_26 = 16)
		: base(int_23, int_24, int_25, int_26)
	{
		int_22 = 1;
		string_2 = Class16.smethod_0(-561796446);
	}

	public override void vmethod_14(ref GClass91 gclass91_1)
	{
		base.vmethod_14(ref gclass91_1);
		int num = int_22;
		checked
		{
			num = (int)Math.Round((double)num + Class24.smethod_1(gclass91_1.method_1(7), 20.0));
			if (Class24.smethod_0(1, 100) == 1)
			{
				gclass91_1.method_0(7, 0);
				gclass91_1.method_5(Class16.smethod_0(-561796410));
				method_17(1);
			}
			num = int_22;
			num = (int)Math.Round((double)num + Class24.smethod_1(gclass91_1.method_1(6), 20.0));
			if (Class24.smethod_0(1, 100) == 1)
			{
				gclass91_1.method_0(6, 0);
				gclass91_1.method_5(Class16.smethod_0(-561796362));
				method_17(1);
			}
		}
	}
}
