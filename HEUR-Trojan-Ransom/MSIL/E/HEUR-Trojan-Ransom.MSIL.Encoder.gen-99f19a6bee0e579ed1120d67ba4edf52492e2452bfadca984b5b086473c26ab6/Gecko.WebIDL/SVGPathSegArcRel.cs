namespace Gecko.WebIDL;

public class SVGPathSegArcRel : WebIDLBase
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

	public float R1
	{
		get
		{
			return GetProperty<float>("r1");
		}
		set
		{
			SetProperty("r1", value);
		}
	}

	public float R2
	{
		get
		{
			return GetProperty<float>("r2");
		}
		set
		{
			SetProperty("r2", value);
		}
	}

	public float Angle
	{
		get
		{
			return GetProperty<float>("angle");
		}
		set
		{
			SetProperty("angle", value);
		}
	}

	public bool LargeArcFlag
	{
		get
		{
			return GetProperty<bool>("largeArcFlag");
		}
		set
		{
			SetProperty("largeArcFlag", value);
		}
	}

	public bool SweepFlag
	{
		get
		{
			return GetProperty<bool>("sweepFlag");
		}
		set
		{
			SetProperty("sweepFlag", value);
		}
	}

	public SVGPathSegArcRel(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
