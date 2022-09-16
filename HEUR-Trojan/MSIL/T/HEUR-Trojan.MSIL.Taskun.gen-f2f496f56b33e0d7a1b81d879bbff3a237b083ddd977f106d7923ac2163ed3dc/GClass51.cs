using System.Collections.Generic;

public sealed class GClass51 : GClass48
{
	public GClass51(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		double_0 = 15.0;
		double_1 = 12.0;
		string_2 = Class16.smethod_0(-561792666);
	}

	public override void vmethod_19(ref List<GClass9> list_3)
	{
		base.vmethod_19(ref list_3);
		if (method_7() >= int_5)
		{
			return;
		}
		int num = 0;
		checked
		{
			do
			{
				GClass9 gClass = gclass97_0.list_1[Class24.smethod_0(0, gclass97_0.list_1.Count - 1)];
				if (!(!gClass.Equals(this) & (gClass.list_1.Count > 0)))
				{
					num++;
					continue;
				}
				GClass91 gclass91_ = gClass.list_1[Class24.smethod_0(0, gClass.list_1.Count - 1)];
				method_12(ref gclass91_, bool_0: true);
				gclass91_.method_3(3, -10, Class16.smethod_0(-561792644));
				Class24.gclass90_0.gclass0_11.method_0(method_6() + Class16.smethod_0(-561792618) + gclass91_.string_0);
				break;
			}
			while (num <= 10);
		}
	}
}
