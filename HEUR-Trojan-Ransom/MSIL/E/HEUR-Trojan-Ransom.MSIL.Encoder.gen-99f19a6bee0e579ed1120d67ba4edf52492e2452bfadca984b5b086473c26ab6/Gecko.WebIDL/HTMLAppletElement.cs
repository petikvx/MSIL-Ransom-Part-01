namespace Gecko.WebIDL;

public class HTMLAppletElement : WebIDLBase
{
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

	public string Archive
	{
		get
		{
			return GetProperty<string>("archive");
		}
		set
		{
			SetProperty("archive", value);
		}
	}

	public string Code
	{
		get
		{
			return GetProperty<string>("code");
		}
		set
		{
			SetProperty("code", value);
		}
	}

	public string CodeBase
	{
		get
		{
			return GetProperty<string>("codeBase");
		}
		set
		{
			SetProperty("codeBase", value);
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

	public uint Hspace
	{
		get
		{
			return GetProperty<uint>("hspace");
		}
		set
		{
			SetProperty("hspace", value);
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

	public string _object
	{
		get
		{
			return GetProperty<string>("_object");
		}
		set
		{
			SetProperty("_object", value);
		}
	}

	public uint Vspace
	{
		get
		{
			return GetProperty<uint>("vspace");
		}
		set
		{
			SetProperty("vspace", value);
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

	public HTMLAppletElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
