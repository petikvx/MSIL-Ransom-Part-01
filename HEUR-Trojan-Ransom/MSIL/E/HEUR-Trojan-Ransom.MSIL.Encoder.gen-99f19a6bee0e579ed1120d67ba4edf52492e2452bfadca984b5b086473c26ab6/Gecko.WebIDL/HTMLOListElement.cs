namespace Gecko.WebIDL;

public class HTMLOListElement : WebIDLBase
{
	public bool Reversed
	{
		get
		{
			return GetProperty<bool>("reversed");
		}
		set
		{
			SetProperty("reversed", value);
		}
	}

	public int Start
	{
		get
		{
			return GetProperty<int>("start");
		}
		set
		{
			SetProperty("start", value);
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

	public HTMLOListElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
