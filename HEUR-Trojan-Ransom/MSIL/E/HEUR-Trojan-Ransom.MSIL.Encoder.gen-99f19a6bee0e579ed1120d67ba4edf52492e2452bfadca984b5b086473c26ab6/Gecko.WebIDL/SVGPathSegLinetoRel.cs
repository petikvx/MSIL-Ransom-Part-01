namespace Gecko.WebIDL;

public class SVGPathSegLinetoRel : WebIDLBase
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

	public SVGPathSegLinetoRel(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
