public sealed class GClass41 : GClass9
{
	public GClass41(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		int_8 = 2;
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		int num = vmethod_10();
		checked
		{
			int num2 = gclass97_0.int_0 - num;
			int num3 = gclass97_0.int_0 + num;
			for (int i = num2; i <= num3; i++)
			{
				int num4 = gclass97_0.int_1 - num;
				int num5 = gclass97_0.int_1 + num;
				for (int j = num4; j <= num5; j++)
				{
					GClass97 gClass = Class24.smethod_2(i, j);
					if (gClass != null)
					{
						int num6 = gclass97_0.method_26(ref gClass);
						if (unchecked(gClass.method_19() && num6 <= num))
						{
							gClass.method_23();
						}
					}
				}
			}
		}
	}
}
