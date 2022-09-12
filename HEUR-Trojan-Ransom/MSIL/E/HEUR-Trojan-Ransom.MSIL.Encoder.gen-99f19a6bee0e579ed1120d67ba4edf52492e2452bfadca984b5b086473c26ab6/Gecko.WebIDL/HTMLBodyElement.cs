namespace Gecko.WebIDL;

public class HTMLBodyElement : WebIDLBase
{
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

	public string Link
	{
		get
		{
			return GetProperty<string>("link");
		}
		set
		{
			SetProperty("link", value);
		}
	}

	public string VLink
	{
		get
		{
			return GetProperty<string>("vLink");
		}
		set
		{
			SetProperty("vLink", value);
		}
	}

	public string ALink
	{
		get
		{
			return GetProperty<string>("aLink");
		}
		set
		{
			SetProperty("aLink", value);
		}
	}

	public string BgColor
	{
		get
		{
			return GetProperty<string>("bgColor");
		}
		set
		{
			SetProperty("bgColor", value);
		}
	}

	public string Background
	{
		get
		{
			return GetProperty<string>("background");
		}
		set
		{
			SetProperty("background", value);
		}
	}

	public HTMLBodyElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
