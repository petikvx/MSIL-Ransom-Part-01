namespace Gecko.WebIDL;

public class HTMLDListElement : WebIDLBase
{
	public bool Compact
	{
		get
		{
			return GetProperty<bool>("compact");
		}
		set
		{
			SetProperty("compact", value);
		}
	}

	public HTMLDListElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
