namespace Gecko.WebIDL;

public class HTMLContentElement : WebIDLBase
{
	public string Select
	{
		get
		{
			return GetProperty<string>("select");
		}
		set
		{
			SetProperty("select", value);
		}
	}

	public HTMLContentElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetDistributedNodes()
	{
		return CallMethod<nsISupports>("getDistributedNodes", new object[0]);
	}
}
