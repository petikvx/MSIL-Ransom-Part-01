namespace Gecko.WebIDL;

public class SVGPathSegLinetoVerticalRel : WebIDLBase
{
	public float Y
	{
		get
		{
			return GetProperty<float>("y");
		}
		set
		{
			SetProperty("y", value);
		}
	}

	public SVGPathSegLinetoVerticalRel(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
