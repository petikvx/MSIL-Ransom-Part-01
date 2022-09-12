namespace Gecko.WebIDL;

public class SettingsManager : WebIDLBase
{
	public SettingsManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports CreateLock()
	{
		return CallMethod<nsISupports>("createLock", new object[0]);
	}
}
