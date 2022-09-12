namespace Gecko.WebIDL;

public class MozApplicationEvent : WebIDLBase
{
	public nsISupports Application => GetProperty<nsISupports>("application");

	public MozApplicationEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
