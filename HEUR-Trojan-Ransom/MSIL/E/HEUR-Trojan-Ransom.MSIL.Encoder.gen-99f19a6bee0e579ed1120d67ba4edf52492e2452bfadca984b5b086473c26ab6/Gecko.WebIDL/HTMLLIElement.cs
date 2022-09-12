namespace Gecko.WebIDL;

public class HTMLLIElement : WebIDLBase
{
	public int Value
	{
		get
		{
			return GetProperty<int>("value");
		}
		set
		{
			SetProperty("value", value);
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

	public HTMLLIElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
