namespace Gecko.WebIDL;

public class ScreenOrientation : WebIDLBase
{
	public OrientationType Type => GetProperty<OrientationType>("type");

	public ushort Angle => GetProperty<ushort>("angle");

	public ScreenOrientation(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise Lock(OrientationLockType orientation)
	{
		return CallMethod<Promise>("lock", new object[1] { orientation });
	}

	public void Unlock()
	{
		CallVoidMethod("unlock");
	}
}
