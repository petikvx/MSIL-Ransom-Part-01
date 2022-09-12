namespace Gecko.WebIDL;

public class XMLDocument : WebIDLBase
{
	public bool Async
	{
		get
		{
			return GetProperty<bool>("async");
		}
		set
		{
			SetProperty("async", value);
		}
	}

	public XMLDocument(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public bool Load(string url)
	{
		return CallMethod<bool>("load", new object[1] { url });
	}
}
