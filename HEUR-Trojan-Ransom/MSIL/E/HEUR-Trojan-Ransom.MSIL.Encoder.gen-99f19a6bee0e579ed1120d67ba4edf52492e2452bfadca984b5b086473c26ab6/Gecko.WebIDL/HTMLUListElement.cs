namespace Gecko.WebIDL;

public class HTMLUListElement : WebIDLBase
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

	public string Type
	{
		get
		{
			return GetProperty<string>("type");
		}
		set
		{
			SetProperty("type", value);
		}
	}

	public HTMLUListElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
