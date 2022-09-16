public sealed class GClass44 : GClass9
{
	public int int_22;

	public GClass44(int int_23, int int_24, int int_25, int int_26 = 16)
		: base(int_23, int_24, int_25, int_26)
	{
		int_22 = -1;
		string_2 = Class16.smethod_0(-561780752);
		int_22 = Class24.smethod_0(0, 105);
		method_4(Class16.smethod_0(-561781241) + Class24.gclass6_0.method_0(int_22) + Class16.smethod_0(-561781193));
	}

	public override string vmethod_6()
	{
		if (int_4 == 4)
		{
			return Class16.smethod_0(-561781185);
		}
		return base.vmethod_6();
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		Class24.list_0[int_10].list_0.Add(int_22);
	}

	public override void vmethod_35()
	{
		Class24.list_0[int_10].list_0.Remove(int_22);
		base.vmethod_35();
	}
}
