namespace Gecko.WebIDL;

public class MozSettingsTransactionEvent : WebIDLBase
{
	public string Error => GetProperty<string>("error");

	public MozSettingsTransactionEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
