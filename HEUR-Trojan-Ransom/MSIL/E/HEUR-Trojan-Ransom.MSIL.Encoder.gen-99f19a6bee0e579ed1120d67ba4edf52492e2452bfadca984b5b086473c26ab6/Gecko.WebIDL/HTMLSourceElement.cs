namespace Gecko.WebIDL;

public class HTMLSourceElement : WebIDLBase
{
	public string Src
	{
		get
		{
			return GetProperty<string>("src");
		}
		set
		{
			SetProperty("src", value);
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

	public string Srcset
	{
		get
		{
			return GetProperty<string>("srcset");
		}
		set
		{
			SetProperty("srcset", value);
		}
	}

	public string Sizes
	{
		get
		{
			return GetProperty<string>("sizes");
		}
		set
		{
			SetProperty("sizes", value);
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

	public HTMLSourceElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
