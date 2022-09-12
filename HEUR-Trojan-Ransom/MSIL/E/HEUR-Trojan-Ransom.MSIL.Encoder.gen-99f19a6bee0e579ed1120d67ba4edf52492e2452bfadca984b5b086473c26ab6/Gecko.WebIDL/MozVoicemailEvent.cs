namespace Gecko.WebIDL;

public class MozVoicemailEvent : WebIDLBase
{
	public nsISupports Status => GetProperty<nsISupports>("status");

	public MozVoicemailEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
