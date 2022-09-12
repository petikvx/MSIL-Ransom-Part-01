namespace Gecko.WebIDL;

public class SVGStyleElement : WebIDLBase
{
	public string Xmlspace
	{
		get
		{
			return GetProperty<string>("xmlspace");
		}
		set
		{
			SetProperty("xmlspace", value);
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

	public string Title
	{
		get
		{
			return GetProperty<string>("title");
		}
		set
		{
			SetProperty("title", value);
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

	public SVGStyleElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
