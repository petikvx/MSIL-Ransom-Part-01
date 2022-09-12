namespace Gecko.WebIDL;

public class Screen : WebIDLBase
{
	public int AvailWidth => GetProperty<int>("availWidth");

	public int AvailHeight => GetProperty<int>("availHeight");

	public int Width => GetProperty<int>("width");

	public int Height => GetProperty<int>("height");

	public int ColorDepth => GetProperty<int>("colorDepth");

	public int PixelDepth => GetProperty<int>("pixelDepth");

	public int Top => GetProperty<int>("top");

	public int Left => GetProperty<int>("left");

	public int AvailTop => GetProperty<int>("availTop");

	public int AvailLeft => GetProperty<int>("availLeft");

	public string MozOrientation => GetProperty<string>("mozOrientation");

	public nsISupports Orientation => GetProperty<nsISupports>("orientation");

	public Screen(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public bool MozLockOrientation(string orientation)
	{
		return CallMethod<bool>("mozLockOrientation", new object[1] { orientation });
	}

	public bool MozLockOrientation(string[] orientation)
	{
		return CallMethod<bool>("mozLockOrientation", orientation);
	}

	public void MozUnlockOrientation()
	{
		CallVoidMethod("mozUnlockOrientation");
	}
}
