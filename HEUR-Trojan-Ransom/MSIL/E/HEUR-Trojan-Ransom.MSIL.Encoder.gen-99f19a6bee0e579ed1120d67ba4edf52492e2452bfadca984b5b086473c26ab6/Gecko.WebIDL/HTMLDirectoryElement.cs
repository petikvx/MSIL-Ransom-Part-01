namespace Gecko.WebIDL;

public class HTMLDirectoryElement : WebIDLBase
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

	public HTMLDirectoryElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
