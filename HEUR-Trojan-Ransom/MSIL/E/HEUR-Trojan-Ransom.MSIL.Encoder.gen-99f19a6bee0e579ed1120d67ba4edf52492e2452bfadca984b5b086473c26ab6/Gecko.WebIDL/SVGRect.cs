namespace Gecko.WebIDL;

public class SVGRect : WebIDLBase
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

	public float Width
	{
		get
		{
			return GetProperty<float>("width");
		}
		set
		{
			SetProperty("width", value);
		}
	}

	public float Height
	{
		get
		{
			return GetProperty<float>("height");
		}
		set
		{
			SetProperty("height", value);
		}
	}

	public SVGRect(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
