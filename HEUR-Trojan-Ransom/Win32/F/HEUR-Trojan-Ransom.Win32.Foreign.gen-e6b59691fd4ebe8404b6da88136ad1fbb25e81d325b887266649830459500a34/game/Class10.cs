namespace game;

internal class Class10 : Class9
{
	public Class10(int int_2, int int_3, Class7 class7_0)
		: base(int_2, int_3)
	{
		if (!class7_0.method_0(this))
		{
			throw new Exception1(string.Concat(this, "  is outside the boundaries of the map."));
		}
	}

	public bool method_2(Class10 class10_0, int int_2)
	{
		return method_1(class10_0) <= int_2;
	}
}
