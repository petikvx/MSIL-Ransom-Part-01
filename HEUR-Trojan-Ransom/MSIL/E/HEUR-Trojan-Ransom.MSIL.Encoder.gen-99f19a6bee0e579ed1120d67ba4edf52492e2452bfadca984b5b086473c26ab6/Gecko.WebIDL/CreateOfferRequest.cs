namespace Gecko.WebIDL;

public class CreateOfferRequest : WebIDLBase
{
	public ulong WindowID => GetProperty<ulong>("windowID");

	public ulong InnerWindowID => GetProperty<ulong>("innerWindowID");

	public string CallID => GetProperty<string>("callID");

	public bool IsSecure => GetProperty<bool>("isSecure");

	public CreateOfferRequest(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
