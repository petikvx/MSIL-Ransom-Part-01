namespace Gecko.WebIDL;

public class DOMRect : WebIDLBase
{
	public double X
	{
		get
		{
			return GetProperty<double>("x");
		}
		set
		{
			SetProperty("x", value);
		}
	}

	public double Y
	{
		get
		{
			return GetProperty<double>("y");
		}
		set
		{
			SetProperty("y", value);
		}
	}

	public double Width
	{
		get
		{
			return GetProperty<double>("width");
		}
		set
		{
			SetProperty("width", value);
		}
	}

	public double Height
	{
		get
		{
			return GetProperty<double>("height");
		}
		set
		{
			SetProperty("height", value);
		}
	}

	public DOMRect(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
