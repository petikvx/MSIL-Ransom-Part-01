namespace Gecko.WebIDL;

public class VTTRegion : WebIDLBase
{
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

	public int Lines
	{
		get
		{
			return GetProperty<int>("lines");
		}
		set
		{
			SetProperty("lines", value);
		}
	}

	public double RegionAnchorX
	{
		get
		{
			return GetProperty<double>("regionAnchorX");
		}
		set
		{
			SetProperty("regionAnchorX", value);
		}
	}

	public double RegionAnchorY
	{
		get
		{
			return GetProperty<double>("regionAnchorY");
		}
		set
		{
			SetProperty("regionAnchorY", value);
		}
	}

	public double ViewportAnchorX
	{
		get
		{
			return GetProperty<double>("viewportAnchorX");
		}
		set
		{
			SetProperty("viewportAnchorX", value);
		}
	}

	public double ViewportAnchorY
	{
		get
		{
			return GetProperty<double>("viewportAnchorY");
		}
		set
		{
			SetProperty("viewportAnchorY", value);
		}
	}

	public string Scroll
	{
		get
		{
			return GetProperty<string>("scroll");
		}
		set
		{
			SetProperty("scroll", value);
		}
	}

	public VTTRegion(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
