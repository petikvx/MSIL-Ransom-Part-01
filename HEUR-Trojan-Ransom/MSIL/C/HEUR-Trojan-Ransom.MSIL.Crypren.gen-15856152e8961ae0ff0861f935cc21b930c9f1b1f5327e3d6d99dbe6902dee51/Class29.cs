internal class Class29 : Class28
{
	private bool bool_1;

	public Class29(Class27 class27_1)
		: base(class27_1)
	{
	}

	public override void Dispose()
	{
		bool_1 = true;
		Delegate171.smethod_0(this);
	}

	public override bool vmethod_0(Enum10 enum10_0)
	{
		bool result = Delegate172.smethod_0(this, enum10_0);
		if ((bool_0 || 1 == 0) && !bool_1 && 0 == 0)
		{
			throw Delegate57.smethod_0(Delegate173.smethod_0(this), "Session has unexpectedly closed");
		}
		return result;
	}
}
