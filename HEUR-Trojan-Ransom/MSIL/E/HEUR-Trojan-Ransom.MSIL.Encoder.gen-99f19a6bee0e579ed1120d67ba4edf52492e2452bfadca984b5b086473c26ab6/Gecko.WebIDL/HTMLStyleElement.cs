namespace Gecko.WebIDL;

public class HTMLStyleElement : WebIDLBase
{
	public bool Disabled
	{
		get
		{
			return GetProperty<bool>("disabled");
		}
		set
		{
			SetProperty("disabled", value);
		}
	}

	public string Media
	{
		get
		{
			return GetProperty<string>("media");
		}
		set
		{
			SetProperty("media", value);
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

	public bool Scoped
	{
		get
		{
			return GetProperty<bool>("scoped");
		}
		set
		{
			SetProperty("scoped", value);
		}
	}

	public HTMLStyleElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
