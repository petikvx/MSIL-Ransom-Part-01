namespace Gecko.WebIDL;

public class Location : WebIDLBase
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

	public Location(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Assign(USVString url)
	{
		CallVoidMethod("assign", url);
	}

	public void Replace(USVString url)
	{
		CallVoidMethod("replace", url);
	}

	public void Reload()
	{
		CallVoidMethod("reload");
	}

	public void Reload(bool forceget)
	{
		CallVoidMethod("reload", forceget);
	}
}
