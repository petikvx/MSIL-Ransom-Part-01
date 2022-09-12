namespace Gecko.WebIDL;

public class AudioListener : WebIDLBase
{
	public double DopplerFactor
	{
		get
		{
			return GetProperty<double>("dopplerFactor");
		}
		set
		{
			SetProperty("dopplerFactor", value);
		}
	}

	public double SpeedOfSound
	{
		get
		{
			return GetProperty<double>("speedOfSound");
		}
		set
		{
			SetProperty("speedOfSound", value);
		}
	}

	public AudioListener(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetPosition(double x, double y, double z)
	{
		CallVoidMethod("setPosition", x, y, z);
	}

	public void SetOrientation(double x, double y, double z, double xUp, double yUp, double zUp)
	{
		CallVoidMethod("setOrientation", x, y, z, xUp, yUp, zUp);
	}

	public void SetVelocity(double x, double y, double z)
	{
		CallVoidMethod("setVelocity", x, y, z);
	}
}
