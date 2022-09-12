namespace Gecko.WebIDL;

public class PannerNode : WebIDLBase
{
	public PanningModelType PanningModel
	{
		get
		{
			return GetProperty<PanningModelType>("panningModel");
		}
		set
		{
			SetProperty("panningModel", value);
		}
	}

	public DistanceModelType DistanceModel
	{
		get
		{
			return GetProperty<DistanceModelType>("distanceModel");
		}
		set
		{
			SetProperty("distanceModel", value);
		}
	}

	public double RefDistance
	{
		get
		{
			return GetProperty<double>("refDistance");
		}
		set
		{
			SetProperty("refDistance", value);
		}
	}

	public double MaxDistance
	{
		get
		{
			return GetProperty<double>("maxDistance");
		}
		set
		{
			SetProperty("maxDistance", value);
		}
	}

	public double RolloffFactor
	{
		get
		{
			return GetProperty<double>("rolloffFactor");
		}
		set
		{
			SetProperty("rolloffFactor", value);
		}
	}

	public double ConeInnerAngle
	{
		get
		{
			return GetProperty<double>("coneInnerAngle");
		}
		set
		{
			SetProperty("coneInnerAngle", value);
		}
	}

	public double ConeOuterAngle
	{
		get
		{
			return GetProperty<double>("coneOuterAngle");
		}
		set
		{
			SetProperty("coneOuterAngle", value);
		}
	}

	public double ConeOuterGain
	{
		get
		{
			return GetProperty<double>("coneOuterGain");
		}
		set
		{
			SetProperty("coneOuterGain", value);
		}
	}

	public PannerNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetPosition(double x, double y, double z)
	{
		CallVoidMethod("setPosition", x, y, z);
	}

	public void SetOrientation(double x, double y, double z)
	{
		CallVoidMethod("setOrientation", x, y, z);
	}

	public void SetVelocity(double x, double y, double z)
	{
		CallVoidMethod("setVelocity", x, y, z);
	}
}
