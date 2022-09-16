using System;
using System.Collections.Generic;

public class GClass58 : GClass9
{
	public double double_0;

	public GClass58(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		double_0 = 0.0;
	}

	public override int vmethod_11(int int_22)
	{
		if (base.vmethod_11(int_22) > 0)
		{
			return checked((int)Math.Round((double)base.vmethod_11(int_22) + double_0));
		}
		return base.vmethod_11(int_22);
	}

	public virtual void vmethod_36()
	{
		int num = 0;
		List<GClass97> list = gclass97_0.method_40();
		foreach (GClass97 item in list)
		{
			if (item.method_14(12) != 0)
			{
				num = checked(num + 1);
			}
		}
		double_0 = (double)num * 10.0;
	}

	public override void vmethod_21()
	{
		base.vmethod_21();
		vmethod_36();
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		vmethod_36();
	}
}
