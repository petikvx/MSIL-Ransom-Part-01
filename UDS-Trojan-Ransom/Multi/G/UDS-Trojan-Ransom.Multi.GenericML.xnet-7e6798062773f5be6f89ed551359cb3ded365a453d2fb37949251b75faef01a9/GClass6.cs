public sealed class GClass6 : GInterface10<a, int>
{
	private bool bool_0;

	public GClass6(bool bool_1 = true)
	{
		bool_0 = true;
		bool_0 = bool_1;
	}

	public bool method_0()
	{
		return bool_0;
	}

	public int imethod_0(a a_0)
	{
		a.CardFace cardFace = a_0.imethod_0();
		if (cardFace == a.CardFace.Ace)
		{
			return (!method_0()) ? 1 : 11;
		}
		if (cardFace > a.CardFace.Ten)
		{
			return 10;
		}
		return (int)a_0.imethod_0();
	}
}
