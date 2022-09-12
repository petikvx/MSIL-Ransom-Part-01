namespace Gecko.WebIDL;

public class SVGPathSegLinetoVerticalAbs : WebIDLBase
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

	public SVGPathSegLinetoVerticalAbs(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
