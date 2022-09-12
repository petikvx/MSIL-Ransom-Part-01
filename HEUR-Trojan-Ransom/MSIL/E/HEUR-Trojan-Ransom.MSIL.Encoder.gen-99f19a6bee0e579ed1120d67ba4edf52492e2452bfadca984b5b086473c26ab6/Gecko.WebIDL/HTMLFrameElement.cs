namespace Gecko.WebIDL;

public class HTMLFrameElement : WebIDLBase
{
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

	public string Scrolling
	{
		get
		{
			return GetProperty<string>("scrolling");
		}
		set
		{
			SetProperty("scrolling", value);
		}
	}

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

	public string FrameBorder
	{
		get
		{
			return GetProperty<string>("frameBorder");
		}
		set
		{
			SetProperty("frameBorder", value);
		}
	}

	public string LongDesc
	{
		get
		{
			return GetProperty<string>("longDesc");
		}
		set
		{
			SetProperty("longDesc", value);
		}
	}

	public bool NoResize
	{
		get
		{
			return GetProperty<bool>("noResize");
		}
		set
		{
			SetProperty("noResize", value);
		}
	}

	public nsIDOMDocument ContentDocument => GetProperty<nsIDOMDocument>("contentDocument");

	public nsIDOMWindow ContentWindow => GetProperty<nsIDOMWindow>("contentWindow");

	public string MarginHeight
	{
		get
		{
			return GetProperty<string>("marginHeight");
		}
		set
		{
			SetProperty("marginHeight", value);
		}
	}

	public string MarginWidth
	{
		get
		{
			return GetProperty<string>("marginWidth");
		}
		set
		{
			SetProperty("marginWidth", value);
		}
	}

	public HTMLFrameElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
