namespace Gecko.WebIDL;

public class DOMSettableTokenList : WebIDLBase
{
	public string Value
	{
		get
		{
			return GetProperty<string>("value");
		}
		set
		{
			SetProperty("value", value);
		}
	}

	public DOMSettableTokenList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
