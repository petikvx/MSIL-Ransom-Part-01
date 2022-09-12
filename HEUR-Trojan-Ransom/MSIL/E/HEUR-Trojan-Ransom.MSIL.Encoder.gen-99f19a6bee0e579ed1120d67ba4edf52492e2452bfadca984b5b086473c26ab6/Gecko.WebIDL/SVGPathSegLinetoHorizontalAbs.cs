namespace Gecko.WebIDL;

public class SVGPathSegLinetoHorizontalAbs : WebIDLBase
{
	public float X
	{
		get
		{
			return GetProperty<float>("x");
		}
		set
		{
			SetProperty("x", value);
		}
	}

	public SVGPathSegLinetoHorizontalAbs(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
