namespace Gecko.WebIDL;

public class SVGAnimatedInteger : WebIDLBase
{
	public int BaseVal
	{
		get
		{
			return GetProperty<int>("baseVal");
		}
		set
		{
			SetProperty("baseVal", value);
		}
	}

	public int AnimVal => GetProperty<int>("animVal");

	public SVGAnimatedInteger(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
