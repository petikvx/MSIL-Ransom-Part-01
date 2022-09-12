namespace Gecko.WebIDL;

public class HTMLAnchorElement : WebIDLBase
{
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

	public string Download
	{
		get
		{
			return GetProperty<string>("download");
		}
		set
		{
			SetProperty("download", value);
		}
	}

	public string Ping
	{
		get
		{
			return GetProperty<string>("ping");
		}
		set
		{
			SetProperty("ping", value);
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

	public string ReferrerPolicy
	{
		get
		{
			return GetProperty<string>("referrerPolicy");
		}
		set
		{
			SetProperty("referrerPolicy", value);
		}
	}

	public nsISupports RelList => GetProperty<nsISupports>("relList");

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

	public string Text
	{
		get
		{
			return GetProperty<string>("text");
		}
		set
		{
			SetProperty("text", value);
		}
	}

	public string Coords
	{
		get
		{
			return GetProperty<string>("coords");
		}
		set
		{
			SetProperty("coords", value);
		}
	}

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

	public string Name
	{
		get
		{
			return GetProperty<string>("name");
		}
		set
		{
			SetProperty("name", value);
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

	public string Shape
	{
		get
		{
			return GetProperty<string>("shape");
		}
		set
		{
			SetProperty("shape", value);
		}
	}

	public HTMLAnchorElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
