using System.Collections.Generic;

public sealed class GClass22 : GClass9
{
	public GClass22(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		checked
		{
			if (gclass97_0.method_13(3) <= 0)
			{
				List<GClass9> list = gclass97_0.method_16(10);
				int num = list.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					GClass9 gClass = list[i];
					gClass.int_8++;
				}
			}
		}
	}

	public override void vmethod_35()
	{
		checked
		{
			if (gclass97_0.method_13(3) <= 1)
			{
				List<GClass9> list = gclass97_0.method_16(10);
				int num = list.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					GClass9 gClass = list[i];
					gClass.int_8--;
				}
				base.vmethod_35();
			}
		}
	}
}
