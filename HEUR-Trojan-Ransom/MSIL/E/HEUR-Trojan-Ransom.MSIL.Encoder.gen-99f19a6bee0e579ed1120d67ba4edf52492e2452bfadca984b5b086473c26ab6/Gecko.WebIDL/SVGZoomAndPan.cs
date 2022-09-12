namespace Gecko.WebIDL;

public class SVGZoomAndPan : WebIDLBase
{
	public ushort ZoomAndPan
	{
		get
		{
			return GetProperty<ushort>("zoomAndPan");
		}
		set
		{
			SetProperty("zoomAndPan", value);
		}
	}

	public SVGZoomAndPan(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
