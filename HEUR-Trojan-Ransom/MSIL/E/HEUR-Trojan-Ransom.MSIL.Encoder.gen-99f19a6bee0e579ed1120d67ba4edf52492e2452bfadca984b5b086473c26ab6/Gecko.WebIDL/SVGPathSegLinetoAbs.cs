namespace Gecko.WebIDL;

public class SVGPathSegLinetoAbs : WebIDLBase
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

	public SVGPathSegLinetoAbs(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
