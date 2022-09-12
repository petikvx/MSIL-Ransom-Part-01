namespace Gecko.WebIDL;

public class IccChangeEvent : WebIDLBase
{
	public string IccId => GetProperty<string>("iccId");

	public IccChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
