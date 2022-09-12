namespace Gecko.WebIDL;

public class PointerEvent : WebIDLBase
{
	public int PointerId => GetProperty<int>("pointerId");

	public int Width => GetProperty<int>("width");

	public int Height => GetProperty<int>("height");

	public float Pressure => GetProperty<float>("pressure");

	public int TiltX => GetProperty<int>("tiltX");

	public int TiltY => GetProperty<int>("tiltY");

	public string PointerType => GetProperty<string>("pointerType");

	public bool IsPrimary => GetProperty<bool>("isPrimary");

	public PointerEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
