using System;

public sealed class GClass84 : GClass9
{
	public GClass84(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
	}

	public override int vmethod_11(int int_22)
	{
		bool flag = false;
		if ((int_22 == 0) & (gclass97_0 != null))
		{
			if (gclass97_0.method_13(88) > 0)
			{
				flag = true;
			}
			else if (gclass97_0.method_13(101) > 0)
			{
				flag = true;
			}
		}
		if (flag)
		{
			return checked((int)Math.Round((double)base.vmethod_11(int_22) * 2.0));
		}
		return base.vmethod_11(int_22);
	}

	public override void vmethod_20()
	{
		if (Class24.smethod_0(0, 1) == 0)
		{
			method_8(4);
		}
		base.vmethod_20();
	}
}
