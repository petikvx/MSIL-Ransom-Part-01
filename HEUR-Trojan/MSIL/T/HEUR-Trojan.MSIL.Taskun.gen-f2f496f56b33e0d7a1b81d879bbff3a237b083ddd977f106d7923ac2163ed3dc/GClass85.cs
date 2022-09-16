public sealed class GClass85 : GClass9
{
	public GClass85(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
	}

	public override int vmethod_11(int int_22)
	{
		if (gclass97_0 != null && gclass97_0.int_6 != 3)
		{
			return 0;
		}
		return base.vmethod_11(int_22);
	}

	public override void vmethod_14(ref GClass91 gclass91_1)
	{
		if (gclass97_0.int_6 == 3)
		{
			base.vmethod_14(ref gclass91_1);
		}
	}

	public override bool vmethod_15(ref GClass91 gclass91_1)
	{
		if (gclass97_0.int_6 == 3)
		{
			return base.vmethod_15(ref gclass91_1);
		}
		return false;
	}
}
