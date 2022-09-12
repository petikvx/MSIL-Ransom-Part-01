namespace Gecko.WebIDL;

public class DOMPoint : WebIDLBase
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

	public double Z
	{
		get
		{
			return GetProperty<double>("z");
		}
		set
		{
			SetProperty("z", value);
		}
	}

	public double W
	{
		get
		{
			return GetProperty<double>("w");
		}
		set
		{
			SetProperty("w", value);
		}
	}

	public DOMPoint(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
