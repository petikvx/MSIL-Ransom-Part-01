using System.Collections.Generic;

public sealed class GClass26 : GClass9
{
	public GClass26(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		string_2 = Class16.smethod_0(-561835236);
	}

	public void method_24(int int_22)
	{
		List<GClass97> list = gclass97_0.method_40();
		checked
		{
			foreach (GClass97 item in list)
			{
				foreach (GClass9 item2 in item.list_1)
				{
					item2.int_9 += int_22;
					method_17(1);
				}
			}
		}
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		method_24(1);
	}

	public override void vmethod_35()
	{
		method_24(-1);
		base.vmethod_35();
	}
}
