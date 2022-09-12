namespace Gecko.WebIDL;

public class HTMLAreaElement : WebIDLBase
{
	public string Alt
	{
		get
		{
			return GetProperty<string>("alt");
		}
		set
		{
			SetProperty("alt", value);
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

	public bool NoHref
	{
		get
		{
			return GetProperty<bool>("noHref");
		}
		set
		{
			SetProperty("noHref", value);
		}
	}

	public HTMLAreaElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
