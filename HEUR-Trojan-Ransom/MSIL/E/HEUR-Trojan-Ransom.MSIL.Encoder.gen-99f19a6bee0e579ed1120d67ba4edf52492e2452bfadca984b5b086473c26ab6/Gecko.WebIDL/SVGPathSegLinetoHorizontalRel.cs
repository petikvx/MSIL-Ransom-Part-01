namespace Gecko.WebIDL;

public class SVGPathSegLinetoHorizontalRel : WebIDLBase
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

	public SVGPathSegLinetoHorizontalRel(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
