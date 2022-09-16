using System;
using System.Collections;
using System.Collections.Generic;

public sealed class GClass62 : GClass58
{
	public double double_1;

	public double double_2;

	public GClass62(int int_22, int int_23, int int_24, int int_25 = 16)
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
		List<int> list = new List<int>();
		List<GClass97> list2 = gclass97_0.method_40();
		list2.Add(gclass97_0);
		foreach (GClass97 item in list2)
		{
			if (!list.Contains(item.int_6))
			{
				list.Add(item.int_6);
			}
		}
		double_1 = list.Count;
		List<int> list3 = new List<int>();
		IEnumerator enumerator2 = Class24.gclass97_0.GetEnumerator();
		while (enumerator2.MoveNext())
		{
			GClass97 gClass = (GClass97)enumerator2.Current;
			if (gClass.method_20(int_10) && !list3.Contains(gClass.int_6))
			{
				list3.Add(gClass.int_6);
			}
		}
		double_2 = (double)list3.Count * 3.0;
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
