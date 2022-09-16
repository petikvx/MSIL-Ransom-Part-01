using System.Collections.Generic;

public sealed class GClass57 : GClass9
{
	public GClass57(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		checked
		{
			if (gclass97_0.int_6 == 0)
			{
				int_9++;
			}
			if (!method_16())
			{
				List<GClass9> list = gclass97_0.method_16(6);
				int num = list.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					GClass9 gClass = list[i];
					gClass.vmethod_1(1, 1.0, bool_0: false);
				}
			}
		}
	}

	public override void vmethod_35()
	{
		checked
		{
			if (!method_16())
			{
				List<GClass9> list = gclass97_0.method_16(6);
				int num = list.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					GClass9 gClass = list[i];
					gClass.vmethod_1(1, -1.0, bool_0: false);
				}
				base.vmethod_35();
			}
		}
	}
}
