using System;
using System.Collections.Generic;

public class GClass32 : GClass9
{
	public enum GEnum4
	{

	}

	public List<double> list_3;

	public double double_0;

	public GClass32(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		list_3 = new List<double>();
		double_0 = 0.0;
		method_1(1);
		string_2 = Class16.smethod_0(-561792715);
	}

	public virtual bool vmethod_36(ref GClass91 gclass91_1, int int_22)
	{
		return true;
	}

	public virtual double vmethod_37(ref GClass91 gclass91_1, int int_22)
	{
		double num = double_0;
		num += Class24.smethod_1(gclass91_1.method_1(7), 8.0);
		return num + Class24.smethod_1(gclass91_1.method_1(6), 8.0);
	}

	public virtual int vmethod_38(ref GClass91 gclass91_1, int int_22)
	{
		if ((double)Class24.smethod_0(1, 100) <= vmethod_37(ref gclass91_1, int_22))
		{
			return 2;
		}
		gclass91_1.method_20();
		return 1;
	}

	public virtual int vmethod_39(int int_22)
	{
		if (int_22 > int_8)
		{
			return 0;
		}
		checked
		{
			if (int_8 > list_3.Count)
			{
				int_22 -= int_8 - list_3.Count;
			}
			double a = list_3[int_22];
			return (int)Math.Round(a);
		}
	}

	public override int vmethod_23(ref GClass91 gclass91_1, int int_22)
	{
		if (!vmethod_36(ref gclass91_1, int_22))
		{
			return 0;
		}
		int num = gclass97_0.method_26(ref gclass91_1.gclass97_1);
		if (num > int_8)
		{
			return 0;
		}
		int num2 = vmethod_39(num);
		if (Class24.smethod_0(1, 100) <= num2)
		{
			method_17(1);
			return vmethod_38(ref gclass91_1, int_22);
		}
		return 0;
	}
}
