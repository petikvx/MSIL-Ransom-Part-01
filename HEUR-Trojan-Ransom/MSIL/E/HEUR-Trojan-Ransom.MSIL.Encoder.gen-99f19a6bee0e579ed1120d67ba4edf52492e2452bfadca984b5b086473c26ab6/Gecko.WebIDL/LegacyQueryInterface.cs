namespace Gecko.WebIDL;

public class LegacyQueryInterface : WebIDLBase
{
	public LegacyQueryInterface(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports QueryInterface(nsISupports iid)
	{
		return CallMethod<nsISupports>("queryInterface", new object[1] { iid });
	}
}
