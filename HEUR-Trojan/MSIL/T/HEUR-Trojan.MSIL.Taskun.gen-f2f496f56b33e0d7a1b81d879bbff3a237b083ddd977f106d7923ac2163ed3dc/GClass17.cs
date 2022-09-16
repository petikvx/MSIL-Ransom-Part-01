using System.Collections.Generic;

public sealed class GClass17 : GClass14
{
	public GClass17(int int_24, int int_25, int int_26, int int_27 = 16)
		: base(int_24, int_25, int_26, int_27)
	{
		method_1(3);
		int_22 = -1;
		int_23 = 8;
	}

	public override void vmethod_19(ref List<GClass9> list_3)
	{
		base.vmethod_19(ref list_3);
		if (Class24.smethod_0(1, 300) != 1)
		{
			return;
		}
		Class24.gclass90_0.gclass0_12.method_1(Class16.smethod_0(-561834856) + gclass97_0.method_18());
		List<GClass91> list = new List<GClass91>();
		checked
		{
			int num = gclass97_0.list_0.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				list.Add(gclass97_0.list_0[i]);
			}
			int num2 = list.Count - 1;
			for (int j = 0; j <= num2; j++)
			{
				list[j].method_14(5);
			}
			foreach (GClass9 item in gclass97_0.list_1)
			{
				list_3.Add(item);
			}
			gclass97_0.int_7 = 0;
		}
	}
}
