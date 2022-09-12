namespace Gecko.WebIDL;

public class HTMLLinkElement : WebIDLBase
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

	public string Href
	{
		get
		{
			return GetProperty<string>("href");
		}
		set
		{
			SetProperty("href", value);
		}
	}

	public string CrossOrigin
	{
		get
		{
			return GetProperty<string>("crossOrigin");
		}
		set
		{
			SetProperty("crossOrigin", value);
		}
	}

	public string Rel
	{
		get
		{
			return GetProperty<string>("rel");
		}
		set
		{
			SetProperty("rel", value);
		}
	}

	public nsISupports RelList => GetProperty<nsISupports>("relList");

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

	public string Hreflang
	{
		get
		{
			return GetProperty<string>("hreflang");
		}
		set
		{
			SetProperty("hreflang", value);
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

	public nsISupports Sizes => GetProperty<nsISupports>("sizes");

	public string Charset
	{
		get
		{
			return GetProperty<string>("charset");
		}
		set
		{
			SetProperty("charset", value);
		}
	}

	public string Rev
	{
		get
		{
			return GetProperty<string>("rev");
		}
		set
		{
			SetProperty("rev", value);
		}
	}

	public string Target
	{
		get
		{
			return GetProperty<string>("target");
		}
		set
		{
			SetProperty("target", value);
		}
	}

	public nsIDOMDocument Import => GetProperty<nsIDOMDocument>("import");

	public string Integrity
	{
		get
		{
			return GetProperty<string>("integrity");
		}
		set
		{
			SetProperty("integrity", value);
		}
	}

	public HTMLLinkElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
