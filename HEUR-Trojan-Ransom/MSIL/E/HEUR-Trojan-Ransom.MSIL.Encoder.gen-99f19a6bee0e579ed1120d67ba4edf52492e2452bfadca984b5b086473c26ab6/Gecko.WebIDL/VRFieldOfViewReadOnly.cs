namespace Gecko.WebIDL;

public class VRFieldOfViewReadOnly : WebIDLBase
{
	public double UpDegrees => GetProperty<double>("upDegrees");

	public double RightDegrees => GetProperty<double>("rightDegrees");

	public double DownDegrees => GetProperty<double>("downDegrees");

	public double LeftDegrees => GetProperty<double>("leftDegrees");

	public VRFieldOfViewReadOnly(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
