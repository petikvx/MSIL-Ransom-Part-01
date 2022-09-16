using System;
using System.Collections.Generic;

public sealed class GClass21 : GClass9
{
	public double double_0;

	public GClass21(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		double_0 = 0.0;
	}

	public override int vmethod_12(int int_22)
	{
		if (int_22 == 6)
		{
			return base.vmethod_12(int_22);
		}
		return checked((int)Math.Round((double)base.vmethod_12(int_22) + double_0));
	}

	public void method_24()
	{
		List<int> list = new List<int>();
		List<GClass97> list2 = gclass97_0.method_40();
		list2.Add(gclass97_0);
		foreach (GClass97 item in list2)
		{
			if (!list.Contains(item.int_6) && ((item.int_6 == 0) | (item.int_6 == 2) | (item.int_6 == 4) | (item.int_6 == 7)))
			{
				list.Add(item.int_6);
			}
		}
		double_0 = list.Count;
	}

	public override void vmethod_21()
	{
		base.vmethod_21();
		method_24();
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		method_24();
	}
}
