namespace Gecko.WebIDL;

public class RadioNodeList : WebIDLBase
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

	public RadioNodeList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
