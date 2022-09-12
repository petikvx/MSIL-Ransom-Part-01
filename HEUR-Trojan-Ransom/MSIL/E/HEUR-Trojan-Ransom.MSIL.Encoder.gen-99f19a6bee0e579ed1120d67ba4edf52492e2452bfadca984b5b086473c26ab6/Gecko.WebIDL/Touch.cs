namespace Gecko.WebIDL;

public class Touch : WebIDLBase
{
	public int Identifier => GetProperty<int>("identifier");

	public nsISupports Target => GetProperty<nsISupports>("target");

	public int ScreenX => GetProperty<int>("screenX");

	public int ScreenY => GetProperty<int>("screenY");

	public int ClientX => GetProperty<int>("clientX");

	public int ClientY => GetProperty<int>("clientY");

	public int PageX => GetProperty<int>("pageX");

	public int PageY => GetProperty<int>("pageY");

	public int RadiusX => GetProperty<int>("radiusX");

	public int RadiusY => GetProperty<int>("radiusY");

	public float RotationAngle => GetProperty<float>("rotationAngle");

	public float Force => GetProperty<float>("force");

	public Touch(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
