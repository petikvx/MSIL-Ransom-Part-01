namespace Gecko.WebIDL;

public class TelephonyCallId : WebIDLBase
{
	public string Number => GetProperty<string>("number");

	public CallIdPresentation NumberPresentation => GetProperty<CallIdPresentation>("numberPresentation");

	public string Name => GetProperty<string>("name");

	public CallIdPresentation NamePresentation => GetProperty<CallIdPresentation>("namePresentation");

	public TelephonyCallId(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
