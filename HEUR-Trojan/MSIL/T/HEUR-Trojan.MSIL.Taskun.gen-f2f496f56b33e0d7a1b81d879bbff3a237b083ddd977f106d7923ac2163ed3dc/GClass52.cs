public sealed class GClass52 : GClass9
{
	public GClass52(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		string_2 = Class16.smethod_0(-561835633);
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		checked
		{
			int num = gclass97_0.list_1.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass9 gClass = gclass97_0.list_1[i];
				if (!gClass.Equals(this))
				{
					gClass.int_5++;
					method_17(1);
				}
			}
		}
	}
}
