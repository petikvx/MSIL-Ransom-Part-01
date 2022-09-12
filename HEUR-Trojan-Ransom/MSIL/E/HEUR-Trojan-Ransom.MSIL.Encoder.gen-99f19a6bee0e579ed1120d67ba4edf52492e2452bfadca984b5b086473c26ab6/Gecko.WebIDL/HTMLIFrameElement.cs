namespace Gecko.WebIDL;

public class HTMLIFrameElement : WebIDLBase
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

	public string Srcdoc
	{
		get
		{
			return GetProperty<string>("srcdoc");
		}
		set
		{
			SetProperty("srcdoc", value);
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

	public nsISupports Sandbox => GetProperty<nsISupports>("sandbox");

	public bool AllowFullscreen
	{
		get
		{
			return GetProperty<bool>("allowFullscreen");
		}
		set
		{
			SetProperty("allowFullscreen", value);
		}
	}

	public string Width
	{
		get
		{
			return GetProperty<string>("width");
		}
		set
		{
			SetProperty("width", value);
		}
	}

	public string Height
	{
		get
		{
			return GetProperty<string>("height");
		}
		set
		{
			SetProperty("height", value);
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

	public nsIDOMDocument ContentDocument => GetProperty<nsIDOMDocument>("contentDocument");

	public nsIDOMWindow ContentWindow => GetProperty<nsIDOMWindow>("contentWindow");

	public string Align
	{
		get
		{
			return GetProperty<string>("align");
		}
		set
		{
			SetProperty("align", value);
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

	public bool Mozbrowser
	{
		get
		{
			return GetProperty<bool>("mozbrowser");
		}
		set
		{
			SetProperty("mozbrowser", value);
		}
	}

	public string AppManifestURL => GetProperty<string>("appManifestURL");

	public HTMLIFrameElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsIDOMDocument GetSVGDocument()
	{
		return CallMethod<nsIDOMDocument>("getSVGDocument", new object[0]);
	}
}
