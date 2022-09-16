using System.Collections.Generic;

public class GClass14 : GClass9
{
	public int int_22;

	public int int_23;

	public GClass14(int int_24, int int_25, int int_26, int int_27 = 16)
		: base(int_24, int_25, int_26, int_27)
	{
		int_22 = -1;
		int_23 = 5;
		method_1(1);
	}

	public void method_24(bool bool_0)
	{
		if (int_22 >= 0)
		{
			if (int_22 == 4)
			{
				if (!gclass97_0.bool_0)
				{
					return;
				}
			}
			else if (int_22 != gclass97_0.int_6)
			{
				return;
			}
		}
		int num = int_23;
		checked
		{
			if (!bool_0)
			{
				num = -int_23;
			}
			List<GClass97> list_ = new List<GClass97>();
			gclass97_0.method_43(vmethod_10(), ref list_);
			foreach (GClass97 item in list_)
			{
				item.int_15 += num;
			}
		}
	}

	public override void vmethod_20()
	{
		method_24(bool_0: true);
		base.vmethod_20();
	}

	public override void vmethod_35()
	{
		method_24(bool_0: false);
		base.vmethod_35();
	}
}
