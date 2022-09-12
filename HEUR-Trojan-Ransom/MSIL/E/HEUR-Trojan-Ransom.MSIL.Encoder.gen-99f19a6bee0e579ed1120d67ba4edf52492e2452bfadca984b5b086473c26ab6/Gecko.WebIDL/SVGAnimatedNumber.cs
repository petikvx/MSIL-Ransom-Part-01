namespace Gecko.WebIDL;

public class SVGAnimatedNumber : WebIDLBase
{
	public float BaseVal
	{
		get
		{
			return GetProperty<float>("baseVal");
		}
		set
		{
			SetProperty("baseVal", value);
		}
	}

	public float AnimVal => GetProperty<float>("animVal");

	public SVGAnimatedNumber(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
