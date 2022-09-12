namespace Gecko.WebIDL;

public class SVGPathSegCurvetoCubicAbs : WebIDLBase
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

	public float X1
	{
		get
		{
			return GetProperty<float>("x1");
		}
		set
		{
			SetProperty("x1", value);
		}
	}

	public float Y1
	{
		get
		{
			return GetProperty<float>("y1");
		}
		set
		{
			SetProperty("y1", value);
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

	public SVGPathSegCurvetoCubicAbs(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
