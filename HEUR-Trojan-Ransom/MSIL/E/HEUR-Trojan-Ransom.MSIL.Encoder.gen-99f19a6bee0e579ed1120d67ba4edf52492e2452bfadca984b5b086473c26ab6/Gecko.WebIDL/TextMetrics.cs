namespace Gecko.WebIDL;

public class TextMetrics : WebIDLBase
{
	public double Width => GetProperty<double>("width");

	public TextMetrics(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
