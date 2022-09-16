public sealed class GClass82 : GClass9
{
	public GClass82(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		int num = 1;
		checked
		{
			if ((int_0 == 12) & (gclass97_0.int_6 == 1))
			{
				num *= 2;
			}
			else if ((int_0 == 39) & gclass97_0.bool_0)
			{
				num *= 2;
			}
			else if ((int_0 == 56) & (gclass97_0.int_6 == 2))
			{
				num *= 2;
			}
			else if ((int_0 == 90) & (gclass97_0.int_6 == 3))
			{
				num *= 2;
			}
			else if ((int_0 == 95) & (gclass97_0.int_6 == 0))
			{
				num *= 2;
			}
			if (gclass97_0.method_13(83) > 0)
			{
				num *= 2;
			}
			int_5 *= num;
		}
	}
}
