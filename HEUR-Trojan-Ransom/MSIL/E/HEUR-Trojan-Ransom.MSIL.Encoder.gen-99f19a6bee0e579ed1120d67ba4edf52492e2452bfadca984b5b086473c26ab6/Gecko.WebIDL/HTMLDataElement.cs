namespace Gecko.WebIDL;

public class HTMLDataElement : WebIDLBase
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

	public HTMLDataElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
