namespace Gecko.WebIDL;

public class SVGAnimatedBoolean : WebIDLBase
{
	public bool BaseVal
	{
		get
		{
			return GetProperty<bool>("baseVal");
		}
		set
		{
			SetProperty("baseVal", value);
		}
	}

	public bool AnimVal => GetProperty<bool>("animVal");

	public SVGAnimatedBoolean(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
