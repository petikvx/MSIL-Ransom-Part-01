namespace Gecko.WebIDL;

public class Presentation : WebIDLBase
{
	public nsISupports DefaultRequest
	{
		get
		{
			return GetProperty<nsISupports>("defaultRequest");
		}
		set
		{
			SetProperty("defaultRequest", value);
		}
	}

	public nsISupports Receiver => GetProperty<nsISupports>("receiver");

	public Presentation(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
