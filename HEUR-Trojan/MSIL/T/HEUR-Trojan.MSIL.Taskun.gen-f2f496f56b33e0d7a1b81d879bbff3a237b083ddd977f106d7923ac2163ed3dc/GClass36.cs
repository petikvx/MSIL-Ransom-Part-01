public sealed class GClass36 : GClass32
{
	public GClass36(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		list_3.Add(95.0);
		list_3.Add(65.0);
		double_0 = 0.0;
		string_2 = Class16.smethod_0(-561834027);
	}

	public override double vmethod_37(ref GClass91 gclass91_1, int int_22)
	{
		double num = base.vmethod_37(ref gclass91_1, int_22);
		return int_22 switch
		{
			5 => num + 100.0, 
			4 => num + 80.0, 
			_ => num + 40.0, 
		};
	}

	public override bool vmethod_36(ref GClass91 gclass91_1, int int_22)
	{
		if (int_22 == 5)
		{
			return true;
		}
		return Class24.smethod_0(1, 100) < 50;
	}
}
