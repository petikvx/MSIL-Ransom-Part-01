namespace Gecko.WebIDL;

public class PaintRequest : WebIDLBase
{
	public nsISupports ClientRect => GetProperty<nsISupports>("clientRect");

	public string Reason => GetProperty<string>("reason");

	public PaintRequest(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
