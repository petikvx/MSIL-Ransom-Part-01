using System;

public sealed class GClass31 : GClass9
{
	public GClass31(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		string_2 = Class16.smethod_0(-561791364);
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		foreach (GClass9 item in gclass97_0.list_1)
		{
			if (item.method_10(4))
			{
				method_17(1);
				item.method_9(4);
			}
		}
	}

	public override void vmethod_31(int int_22)
	{
		checked
		{
			int_20 += int_22;
			int_21 += int_22;
		}
	}

	public override int vmethod_33()
	{
		vmethod_31(checked((int)Math.Round(Class24.smethod_1(int_14, 2.0))));
		return int_18;
	}
}
