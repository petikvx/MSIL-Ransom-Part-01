public sealed class GClass79 : GClass76
{
	public GClass79(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
	}

	public override double vmethod_24(ref GClass91 gclass91_1)
	{
		int num = gclass97_0.method_26(ref gclass91_1.gclass97_1);
		if (num > int_8)
		{
			return 1.0;
		}
		double result = 1.1;
		if (num < int_8)
		{
			result = 1.2;
		}
		return result;
	}
}
