namespace Gecko.WebIDL;

public class VRFieldOfView : WebIDLBase
{
	public double UpDegrees
	{
		get
		{
			return GetProperty<double>("upDegrees");
		}
		set
		{
			SetProperty("upDegrees", value);
		}
	}

	public double RightDegrees
	{
		get
		{
			return GetProperty<double>("rightDegrees");
		}
		set
		{
			SetProperty("rightDegrees", value);
		}
	}

	public double DownDegrees
	{
		get
		{
			return GetProperty<double>("downDegrees");
		}
		set
		{
			SetProperty("downDegrees", value);
		}
	}

	public double LeftDegrees
	{
		get
		{
			return GetProperty<double>("leftDegrees");
		}
		set
		{
			SetProperty("leftDegrees", value);
		}
	}

	public VRFieldOfView(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
