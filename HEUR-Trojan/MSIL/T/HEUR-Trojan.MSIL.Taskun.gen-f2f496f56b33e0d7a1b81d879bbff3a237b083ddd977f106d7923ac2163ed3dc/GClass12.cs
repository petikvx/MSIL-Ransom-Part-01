public sealed class GClass12 : GClass9
{
	public int int_22;

	public int int_23;

	public GClass12(int int_24, int int_25, int int_26, int int_27 = 16)
		: base(int_24, int_25, int_26, int_27)
	{
		int_22 = -1;
		int_23 = -1;
		int_22 = Class24.smethod_0(0, 3);
		int_23 = Class24.smethod_0(5, 20);
		method_4(Class16.smethod_0(-561781012) + int_23 + Class16.smethod_0(-561782517) + checked(int_22 + 1) + Class16.smethod_0(-561781193));
	}

	public override string vmethod_6()
	{
		if (int_4 == 4)
		{
			return Class16.smethod_0(-561782464);
		}
		return base.vmethod_6();
	}

	public int method_24()
	{
		return int_22;
	}

	public int method_25()
	{
		return int_23;
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		Class24.list_0[int_10].list_1.Add(this);
	}

	public override void vmethod_35()
	{
		Class24.list_0[int_10].list_1.Remove(this);
		base.vmethod_35();
	}
}
