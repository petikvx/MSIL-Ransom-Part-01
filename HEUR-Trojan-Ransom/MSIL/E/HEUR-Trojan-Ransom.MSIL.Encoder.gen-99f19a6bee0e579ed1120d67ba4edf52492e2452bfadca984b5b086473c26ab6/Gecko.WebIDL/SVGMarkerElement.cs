namespace Gecko.WebIDL;

public class SVGMarkerElement : WebIDLBase
{
	public nsISupports RefX => GetProperty<nsISupports>("refX");

	public nsISupports RefY => GetProperty<nsISupports>("refY");

	public nsISupports MarkerUnits => GetProperty<nsISupports>("markerUnits");

	public nsISupports MarkerWidth => GetProperty<nsISupports>("markerWidth");

	public nsISupports MarkerHeight => GetProperty<nsISupports>("markerHeight");

	public nsISupports OrientType => GetProperty<nsISupports>("orientType");

	public nsISupports OrientAngle => GetProperty<nsISupports>("orientAngle");

	public SVGMarkerElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetOrientToAuto()
	{
		CallVoidMethod("setOrientToAuto");
	}

	public void SetOrientToAngle(nsISupports angle)
	{
		CallVoidMethod("setOrientToAngle", angle);
	}
}
