using System;

public sealed class GClass29 : GClass9
{
	public GClass29(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		string_2 = Class16.smethod_0(-561781076);
	}

	public override void vmethod_13(int int_22, ref GClass91 gclass91_1)
	{
		int num = vmethod_11(int_22);
		if (gclass91_1.method_30())
		{
			num = checked((int)Math.Round((double)num * 2.0));
		}
		if (num > 0 && Class24.smethod_0(0, 100) <= num)
		{
			int num2 = method_11(vmethod_12(int_22));
			gclass91_1.method_3(int_22, num2, Class16.smethod_0(-561781054) + vmethod_4());
			if (gclass91_1.method_30())
			{
				method_17(1);
			}
		}
	}
}
