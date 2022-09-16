public sealed class GClass56 : GClass9
{
	public GClass56(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		string_2 = Class16.smethod_0(-561834809);
	}

	public override void vmethod_14(ref GClass91 gclass91_1)
	{
		base.vmethod_14(ref gclass91_1);
		if (Class24.smethod_0(1, 100) <= 67)
		{
			int index = Class24.smethod_0(0, checked(gclass97_0.list_1.Count - 1));
			if (gclass97_0.list_1[index].int_0 != 70)
			{
				gclass97_0.list_1[index].vmethod_14(ref gclass91_1);
				method_17(1);
			}
		}
	}
}
