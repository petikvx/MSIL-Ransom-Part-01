namespace Gecko.WebIDL;

public class SVGAnimatedString : WebIDLBase
{
	public string BaseVal
	{
		get
		{
			return GetProperty<string>("baseVal");
		}
		set
		{
			SetProperty("baseVal", value);
		}
	}

	public string AnimVal => GetProperty<string>("animVal");

	public SVGAnimatedString(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
