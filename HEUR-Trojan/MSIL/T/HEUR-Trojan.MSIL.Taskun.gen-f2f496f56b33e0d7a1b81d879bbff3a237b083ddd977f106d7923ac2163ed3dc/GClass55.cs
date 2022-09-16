public sealed class GClass55 : GClass9
{
	public GClass55(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
	}

	public override int vmethod_11(int int_22)
	{
		checked
		{
			if (int_22 == 0 && gclass97_0 != null)
			{
				int num = (gclass97_0.method_4() - 1) * 3;
				return base.vmethod_11(int_22) + num;
			}
			return base.vmethod_11(int_22);
		}
	}
}
