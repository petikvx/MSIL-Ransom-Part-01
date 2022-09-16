public sealed class GClass69 : GClass9
{
	public GClass69(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		string_2 = Class16.smethod_0(-561834809);
	}

	public override void vmethod_14(ref GClass91 gclass91_1)
	{
		base.vmethod_14(ref gclass91_1);
		checked
		{
			int num = gclass97_0.list_1.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if ((gclass97_0.list_1[i].int_0 != 69) & (Class24.smethod_0(1, 100) <= 33))
				{
					gclass97_0.list_1[i].vmethod_14(ref gclass91_1);
					method_17(1);
				}
			}
		}
	}
}
