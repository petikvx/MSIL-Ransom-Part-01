namespace Gecko.WebIDL;

public class SVGPathSegCurvetoCubicSmoothAbs : WebIDLBase
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

	public float X2
	{
		get
		{
			return GetProperty<float>("x2");
		}
		set
		{
			SetProperty("x2", value);
		}
	}

	public float Y2
	{
		get
		{
			return GetProperty<float>("y2");
		}
		set
		{
			SetProperty("y2", value);
		}
	}

	public SVGPathSegCurvetoCubicSmoothAbs(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
