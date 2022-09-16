using System;
using System.Collections.Generic;

public class GClass48 : GClass9
{
	public double double_0;

	public double double_1;

	public GClass48(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		double_0 = 5.0;
		double_1 = 5.0;
		string_2 = Class16.smethod_0(-561792601);
	}

	public void method_24()
	{
		List<GClass97> list = gclass97_0.method_42();
		checked
		{
			GClass97 gClass = list[Class24.smethod_0(0, list.Count - 1)];
			if (gClass.method_19())
			{
				int num = gClass.method_13(int_0);
				int num2 = (int)Math.Round(Math.Floor(Class24.smethod_1(gClass.method_2(), double_1)) + 1.0);
				if (num < num2)
				{
					GClass9 gClass2 = Class24.gclass6_0.method_3(int_0);
					gClass2.int_3 = 0;
					gClass.method_22(gClass2, int_10, bool_1: true);
					Class24.gclass90_0.gclass0_12.method_1(vmethod_4() + Class16.smethod_0(-561834242) + gClass.method_18());
					method_17(1);
				}
			}
		}
	}

	public override void vmethod_19(ref List<GClass9> list_3)
	{
		base.vmethod_19(ref list_3);
		if ((double)Class24.smethod_0(1, 100) <= double_0)
		{
			method_24();
		}
	}
}
