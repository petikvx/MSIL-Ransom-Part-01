namespace Gecko.WebIDL;

public class DOMRectReadOnly : WebIDLBase
{
	public double X => GetProperty<double>("x");

	public double Y => GetProperty<double>("y");

	public double Width => GetProperty<double>("width");

	public double Height => GetProperty<double>("height");

	public double Top => GetProperty<double>("top");

	public double Right => GetProperty<double>("right");

	public double Bottom => GetProperty<double>("bottom");

	public double Left => GetProperty<double>("left");

	public DOMRectReadOnly(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
