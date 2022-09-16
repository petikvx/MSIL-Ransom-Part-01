using System;
using System.Collections.Generic;

public class GClass76 : GClass9
{
	public List<int> list_3;

	public GClass76(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		list_3 = new List<int>();
		method_1(1);
		string_2 = Class16.smethod_0(-561800731);
	}

	public void method_24(int int_22)
	{
		if (!list_3.Contains(int_22))
		{
			list_3.Add(int_22);
		}
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		checked
		{
			if (gclass97_0.method_13(3) > 0)
			{
				int_8++;
			}
			method_24(int_0);
			List<GClass9> list = gclass97_0.method_16(10);
			int num = list.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass9 gClass = list[i];
				gClass.vmethod_21();
			}
		}
	}

	public override void vmethod_21()
	{
		List<GClass9> list = gclass97_0.method_16(10);
		checked
		{
			int num = list.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass9 gClass = list[i];
				method_24(gClass.int_0);
			}
		}
	}

	public virtual bool vmethod_36(ref GClass91 gclass91_1, int int_22)
	{
		return false;
	}

	public int method_25()
	{
		return checked((int)Math.Round((double)(list_3.Count - 1) * 3.0));
	}

	public override bool vmethod_22(ref GClass91 gclass91_1, int int_22)
	{
		if (!vmethod_36(ref gclass91_1, int_22))
		{
			return false;
		}
		int num = gclass97_0.method_26(ref gclass91_1.gclass97_1);
		if (num > int_8)
		{
			return false;
		}
		int num2 = 12;
		if (num < int_8)
		{
			num2 = 25;
		}
		num2 = checked(num2 + method_25());
		if (Class24.smethod_0(1, 100) <= num2)
		{
			method_17(1);
			return true;
		}
		return false;
	}

	public override int vmethod_11(int int_22)
	{
		if (int_22 == 1)
		{
			return checked(base.vmethod_11(int_22) + method_25());
		}
		return base.vmethod_11(int_22);
	}

	public override void vmethod_35()
	{
		checked
		{
			if (!method_16())
			{
				List<GClass9> list = gclass97_0.method_16(10);
				int num = list.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					GClass9 gClass = list[i];
					gClass.vmethod_21();
				}
				base.vmethod_35();
			}
		}
	}
}
