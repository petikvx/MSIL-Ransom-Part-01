using System.Collections.Generic;

public sealed class GClass83 : GClass9
{
	public int int_22;

	public GClass83(int int_23, int int_24, int int_25, int int_26 = 16)
		: base(int_23, int_24, int_25, int_26)
	{
		int_22 = 0;
	}

	public override void vmethod_19(ref List<GClass9> list_3)
	{
		base.vmethod_19(ref list_3);
		int num = gclass97_0.method_2();
		GClass97 gClass;
		int num3;
		checked
		{
			int num2 = int_22 - num;
			int_22 = num;
			if (num2 <= 0 || Class24.smethod_0(1, 6) > num2)
			{
				return;
			}
			List<GClass97> list = gclass97_0.method_42();
			gClass = null;
			num3 = 0;
			int num4 = list.Count - 1;
			for (int i = 0; i <= num4; i++)
			{
				int num5 = list[i].method_2();
				if (num5 > num3)
				{
					num3 = num5;
					gClass = list[i];
				}
			}
		}
		if (gClass != null && num3 > 0)
		{
			GClass9 gclass9_ = Class24.gclass6_0.method_3(79);
			gClass.method_22(gclass9_, gClass.int_2, bool_1: true);
			Class24.gclass90_0.gclass0_12.method_1(vmethod_4() + Class16.smethod_0(-561834394) + gClass.method_18());
			int_22 = num3;
			list_3.Add(this);
		}
	}
}
