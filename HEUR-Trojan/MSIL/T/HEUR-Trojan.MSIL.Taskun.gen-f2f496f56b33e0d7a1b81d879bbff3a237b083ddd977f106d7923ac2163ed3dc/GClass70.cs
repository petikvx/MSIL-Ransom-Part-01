using System.Collections.Generic;

public sealed class GClass70 : GClass9
{
	public static List<GClass97> list_3 = new List<GClass97>();

	public GClass70(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		string_2 = Class16.smethod_0(-561781135);
	}

	public void method_24(ref GClass97 gclass97_1)
	{
		if (!list_3.Contains(gclass97_1))
		{
			list_3.Add(gclass97_1);
		}
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		method_24(ref gclass97_0);
	}

	public override List<GClass97> vmethod_25()
	{
		return list_3;
	}

	public override void vmethod_35()
	{
		if (!method_16())
		{
			list_3.Remove(gclass97_0);
			base.vmethod_35();
		}
	}
}
