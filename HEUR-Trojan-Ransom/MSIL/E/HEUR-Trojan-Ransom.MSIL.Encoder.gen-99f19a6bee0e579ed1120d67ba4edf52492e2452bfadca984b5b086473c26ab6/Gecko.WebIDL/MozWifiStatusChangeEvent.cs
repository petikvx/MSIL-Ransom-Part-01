namespace Gecko.WebIDL;

public class MozWifiStatusChangeEvent : WebIDLBase
{
	public object Network => GetProperty<object>("network");

	public string Status => GetProperty<string>("status");

	public MozWifiStatusChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
