using System;

public sealed class GClass42 : GClass9
{
	public double double_0;

	public GClass42(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		double_0 = 1.0;
	}

	public override int vmethod_12(int int_22)
	{
		return checked((int)Math.Round((double)base.vmethod_12(int_22) * double_0));
	}

	public void method_24()
	{
		if (gclass97_0.method_14(12) > 0)
		{
			double_0 = 0.5;
		}
		else
		{
			double_0 = 1.0;
		}
	}

	public override void vmethod_21()
	{
		base.vmethod_21();
		method_24();
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		method_24();
	}
}
