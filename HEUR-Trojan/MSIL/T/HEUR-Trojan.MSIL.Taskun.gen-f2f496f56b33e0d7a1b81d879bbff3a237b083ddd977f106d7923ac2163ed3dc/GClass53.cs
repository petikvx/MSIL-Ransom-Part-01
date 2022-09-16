using System.Collections.Generic;

public sealed class GClass53 : GClass9
{
	public GClass53 gclass53_0;

	public GClass53(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		gclass53_0 = null;
		string_2 = Class16.smethod_0(-561792440);
	}

	public override string vmethod_4()
	{
		if (int_10 < 0)
		{
			return base.vmethod_4();
		}
		if (gclass53_0 != null)
		{
			return Class16.smethod_0(-561792412) + gclass53_0.gclass97_0.method_18();
		}
		return Class16.smethod_0(-561792387);
	}

	public override List<GClass97> vmethod_25()
	{
		List<GClass97> list = new List<GClass97>();
		if (gclass53_0 != null)
		{
			list.Add(gclass53_0.gclass97_0);
		}
		return list;
	}

	public override bool vmethod_29(ref GClass97 gclass97_1)
	{
		return true;
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		Class24.list_0[int_10].list_2.Add(this);
		Class24.list_0[int_10].list_3.Add(this);
	}

	public override void vmethod_35()
	{
		if (gclass53_0 != null)
		{
			gclass53_0.gclass53_0 = null;
		}
		base.vmethod_35();
	}
}
