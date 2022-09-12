namespace Gecko.WebIDL;

public class DOMPointReadOnly : WebIDLBase
{
	public double X => GetProperty<double>("x");

	public double Y => GetProperty<double>("y");

	public double Z => GetProperty<double>("z");

	public double W => GetProperty<double>("w");

	public DOMPointReadOnly(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
