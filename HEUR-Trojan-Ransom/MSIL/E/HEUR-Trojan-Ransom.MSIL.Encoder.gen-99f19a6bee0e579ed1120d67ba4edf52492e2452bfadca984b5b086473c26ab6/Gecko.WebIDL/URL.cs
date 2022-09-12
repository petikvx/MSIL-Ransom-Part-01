namespace Gecko.WebIDL;

public class URL : WebIDLBase
{
	public USVString Href
	{
		get
		{
			return GetProperty<USVString>("href");
		}
		set
		{
			SetProperty("href", value);
		}
	}

	public USVString Origin => GetProperty<USVString>("origin");

	public USVString Protocol
	{
		get
		{
			return GetProperty<USVString>("protocol");
		}
		set
		{
			SetProperty("protocol", value);
		}
	}

	public USVString Username
	{
		get
		{
			return GetProperty<USVString>("username");
		}
		set
		{
			SetProperty("username", value);
		}
	}

	public USVString Password
	{
		get
		{
			return GetProperty<USVString>("password");
		}
		set
		{
			SetProperty("password", value);
		}
	}

	public USVString Host
	{
		get
		{
			return GetProperty<USVString>("host");
		}
		set
		{
			SetProperty("host", value);
		}
	}

	public USVString Hostname
	{
		get
		{
			return GetProperty<USVString>("hostname");
		}
		set
		{
			SetProperty("hostname", value);
		}
	}

	public USVString Port
	{
		get
		{
			return GetProperty<USVString>("port");
		}
		set
		{
			SetProperty("port", value);
		}
	}

	public USVString Pathname
	{
		get
		{
			return GetProperty<USVString>("pathname");
		}
		set
		{
			SetProperty("pathname", value);
		}
	}

	public USVString Search
	{
		get
		{
			return GetProperty<USVString>("search");
		}
		set
		{
			SetProperty("search", value);
		}
	}

	public nsISupports SearchParams => GetProperty<nsISupports>("searchParams");

	public USVString Hash
	{
		get
		{
			return GetProperty<USVString>("hash");
		}
		set
		{
			SetProperty("hash", value);
		}
	}

	public URL(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
