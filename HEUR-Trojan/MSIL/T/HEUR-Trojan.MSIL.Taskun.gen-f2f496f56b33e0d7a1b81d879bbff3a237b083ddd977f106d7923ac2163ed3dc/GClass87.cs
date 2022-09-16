using System.Collections.Generic;

public sealed class GClass87 : GClass9
{
	public List<GClass91> list_3;

	public GClass87(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		list_3 = new List<GClass91>();
		string_2 = Class16.smethod_0(-561835604);
	}

	public override void vmethod_26(ref int int_22, ref GClass91 gclass91_1)
	{
		int num = gclass97_0.int_7;
		int num2;
		checked
		{
			int_22 -= num;
			num2 = Class24.smethod_0(0, num);
		}
		if (!list_3.Contains(gclass91_1) && num2 > 0)
		{
			list_3.Add(gclass91_1);
			gclass91_1.method_5(Class16.smethod_0(-561835587) + num2);
			vmethod_31(num2);
			method_17(1);
		}
	}

	public override void vmethod_28()
	{
		list_3.Clear();
	}
}
