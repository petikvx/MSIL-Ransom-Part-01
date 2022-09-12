namespace Gecko.WebIDL;

public class AutocompleteErrorEvent : WebIDLBase
{
	public AutoCompleteErrorReason Reason => GetProperty<AutoCompleteErrorReason>("reason");

	public AutocompleteErrorEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
