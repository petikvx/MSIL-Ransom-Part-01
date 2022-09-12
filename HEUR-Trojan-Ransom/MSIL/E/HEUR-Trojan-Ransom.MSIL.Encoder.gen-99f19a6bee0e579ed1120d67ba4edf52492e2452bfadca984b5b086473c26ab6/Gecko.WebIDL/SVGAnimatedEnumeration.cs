namespace Gecko.WebIDL;

public class SVGAnimatedEnumeration : WebIDLBase
{
	public ushort BaseVal
	{
		get
		{
			return GetProperty<ushort>("baseVal");
		}
		set
		{
			SetProperty("baseVal", value);
		}
	}

	public ushort AnimVal => GetProperty<ushort>("animVal");

	public SVGAnimatedEnumeration(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
