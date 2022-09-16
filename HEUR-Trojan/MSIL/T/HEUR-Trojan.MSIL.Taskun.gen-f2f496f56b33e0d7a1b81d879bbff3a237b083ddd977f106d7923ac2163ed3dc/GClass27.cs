using System;

public sealed class GClass27 : GClass9
{
	public GClass27(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
	}

	public override int vmethod_12(int int_22)
	{
		checked
		{
			if (int_22 == 1)
			{
				int num = 0;
				if (gclass97_0 != null)
				{
					num = (int)Math.Floor(Class24.smethod_1(gclass97_0.method_2(), 6.0));
				}
				return base.vmethod_12(int_22) + num;
			}
			return base.vmethod_12(int_22);
		}
	}
}
