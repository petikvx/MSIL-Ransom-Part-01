namespace Gecko;

public class GeckoCreateWindow2EventArgs : GeckoCreateWindowEventArgs
{
	public GeckoCreateWindow2EventArgs(GeckoWindowFlags flags, string uri)
		: base(flags, uri)
	{
	}
}
