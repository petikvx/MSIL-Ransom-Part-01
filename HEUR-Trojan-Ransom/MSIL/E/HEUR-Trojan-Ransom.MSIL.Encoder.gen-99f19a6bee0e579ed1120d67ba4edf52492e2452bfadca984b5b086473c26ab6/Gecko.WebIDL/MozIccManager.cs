namespace Gecko.WebIDL;

public class MozIccManager : WebIDLBase
{
	public string[] IccIds => GetProperty<string[]>("iccIds");

	public MozIccManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetIccById(string iccId)
	{
		return CallMethod<nsISupports>("getIccById", new object[1] { iccId });
	}
}
