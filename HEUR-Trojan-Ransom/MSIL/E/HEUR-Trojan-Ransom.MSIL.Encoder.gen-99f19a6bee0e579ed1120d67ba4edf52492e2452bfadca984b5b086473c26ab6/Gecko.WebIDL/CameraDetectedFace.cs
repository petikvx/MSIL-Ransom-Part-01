namespace Gecko.WebIDL;

public class CameraDetectedFace : WebIDLBase
{
	public uint Id => GetProperty<uint>("id");

	public uint Score => GetProperty<uint>("score");

	public nsISupports Bounds => GetProperty<nsISupports>("bounds");

	public bool HasLeftEye => GetProperty<bool>("hasLeftEye");

	public nsISupports LeftEye => GetProperty<nsISupports>("leftEye");

	public bool HasRightEye => GetProperty<bool>("hasRightEye");

	public nsISupports RightEye => GetProperty<nsISupports>("rightEye");

	public bool HasMouth => GetProperty<bool>("hasMouth");

	public nsISupports Mouth => GetProperty<nsISupports>("mouth");

	public CameraDetectedFace(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
