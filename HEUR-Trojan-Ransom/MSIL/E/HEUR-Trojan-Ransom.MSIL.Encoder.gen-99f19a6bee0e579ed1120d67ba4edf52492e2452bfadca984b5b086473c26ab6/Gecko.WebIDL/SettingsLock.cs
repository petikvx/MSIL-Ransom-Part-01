namespace Gecko.WebIDL;

public class SettingsLock : WebIDLBase
{
	public bool Closed => GetProperty<bool>("closed");

	public SettingsLock(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Set(object settings)
	{
		return CallMethod<nsISupports>("set", new object[1] { settings });
	}

	public nsISupports Get(string name)
	{
		return CallMethod<nsISupports>("get", new object[1] { name });
	}

	public nsISupports Clear()
	{
		return CallMethod<nsISupports>("clear", new object[0]);
	}
}
