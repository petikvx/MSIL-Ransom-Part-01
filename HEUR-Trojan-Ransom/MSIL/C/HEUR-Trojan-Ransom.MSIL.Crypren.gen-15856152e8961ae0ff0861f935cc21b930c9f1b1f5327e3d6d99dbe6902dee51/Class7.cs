internal class Class7 : Class6
{
	private readonly GClass1 gclass1_0;

	public Class7(Class21 class21_1, GClass1 gclass1_1)
		: base(class21_1)
	{
		gclass1_0 = gclass1_1;
		Delegate48.smethod_0(gclass1_0);
	}

	public override void Dispose()
	{
		Delegate49.smethod_0(gclass1_0);
		Delegate50.smethod_0(this);
	}
}
