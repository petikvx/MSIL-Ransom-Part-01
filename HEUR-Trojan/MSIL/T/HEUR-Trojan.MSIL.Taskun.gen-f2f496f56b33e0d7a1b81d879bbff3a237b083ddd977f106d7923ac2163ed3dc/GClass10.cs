public sealed class GClass10 : GClass9
{
	public GClass10(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		checked
		{
			Class24.list_0[int_10].int_16++;
		}
	}

	public override void vmethod_35()
	{
		checked
		{
			Class24.list_0[int_10].int_16--;
			base.vmethod_35();
		}
	}
}
