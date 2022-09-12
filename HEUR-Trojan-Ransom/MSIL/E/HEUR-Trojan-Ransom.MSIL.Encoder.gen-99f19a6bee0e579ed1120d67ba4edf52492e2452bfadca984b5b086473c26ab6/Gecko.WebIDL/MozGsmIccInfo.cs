namespace Gecko.WebIDL;

public class MozGsmIccInfo : WebIDLBase
{
	public string Msisdn => GetProperty<string>("msisdn");

	public MozGsmIccInfo(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
