using System;
using System.Collections;
using System.Collections.Generic;

public sealed class GClass59 : GClass58
{
	public double double_1;

	public double double_2;

	public GClass59(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		double_1 = 0.0;
		double_2 = 0.0;
	}

	public override int vmethod_11(int int_22)
	{
		if (base.vmethod_11(int_22) > 0)
		{
			return checked((int)Math.Round((double)base.vmethod_11(int_22) + double_2));
		}
		return base.vmethod_11(int_22);
	}

	public override int vmethod_12(int int_22)
	{
		return checked((int)Math.Round((double)base.vmethod_12(int_22) + double_1));
	}

	public override void vmethod_36()
	{
		base.vmethod_36();
		int num = 0;
		List<GClass97> list = gclass97_0.method_40();
		list.Add(gclass97_0);
		checked
		{
			foreach (GClass97 item in list)
			{
				if (item.int_6 == 2)
				{
					num++;
				}
			}
			double_1 = num;
			int num2 = 0;
			IEnumerator enumerator2 = Class24.gclass97_0.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				GClass97 gClass = (GClass97)enumerator2.Current;
				if (gClass.method_20(int_10) && gClass.int_6 == 2)
				{
					num2++;
				}
			}
			double_2 = (double)num2 * 2.0;
		}
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
