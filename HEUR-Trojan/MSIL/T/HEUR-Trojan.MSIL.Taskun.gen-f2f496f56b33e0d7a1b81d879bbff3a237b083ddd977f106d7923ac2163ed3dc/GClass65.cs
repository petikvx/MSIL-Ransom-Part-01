using System.Collections.Generic;

public sealed class GClass65 : GClass9
{
	public GClass65(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
	}

	public override void vmethod_19(ref List<GClass9> list_3)
	{
		base.vmethod_19(ref list_3);
		checked
		{
			if (list_1.Count == int_5 && Class24.smethod_0(1, 5) == 1)
			{
				GClass9 gclass9_ = gclass97_0.list_1[Class24.smethod_0(0, gclass97_0.list_1.Count - 1)];
				if (!gclass9_.Equals(this))
				{
					int_5 += gclass9_.int_5;
					method_14(ref gclass9_);
					Class24.gclass90_0.gclass0_12.method_1(method_6() + Class16.smethod_0(-561791337) + gclass9_.vmethod_4());
					list_3.Add(gclass9_);
				}
			}
		}
	}
}
