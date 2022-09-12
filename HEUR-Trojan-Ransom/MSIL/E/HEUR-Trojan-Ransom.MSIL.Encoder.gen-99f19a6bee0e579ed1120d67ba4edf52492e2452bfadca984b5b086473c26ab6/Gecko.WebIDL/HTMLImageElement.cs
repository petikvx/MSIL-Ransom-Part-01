namespace Gecko.WebIDL;

public class HTMLImageElement : WebIDLBase
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

	public string CrossOrigin
	{
		get
		{
			return GetProperty<string>("crossOrigin");
		}
		set
		{
			SetProperty("crossOrigin", value);
		}
	}

	public string UseMap
	{
		get
		{
			return GetProperty<string>("useMap");
		}
		set
		{
			SetProperty("useMap", value);
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

	public bool IsMap
	{
		get
		{
			return GetProperty<bool>("isMap");
		}
		set
		{
			SetProperty("isMap", value);
		}
	}

	public uint Width
	{
		get
		{
			return GetProperty<uint>("width");
		}
		set
		{
			SetProperty("width", value);
		}
	}

	public uint Height
	{
		get
		{
			return GetProperty<uint>("height");
		}
		set
		{
			SetProperty("height", value);
		}
	}

	public uint NaturalWidth => GetProperty<uint>("naturalWidth");

	public uint NaturalHeight => GetProperty<uint>("naturalHeight");

	public bool Complete => GetProperty<bool>("complete");

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

	public string Border
	{
		get
		{
			return GetProperty<string>("border");
		}
		set
		{
			SetProperty("border", value);
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

	public string CurrentSrc => GetProperty<string>("currentSrc");

	public string Lowsrc
	{
		get
		{
			return GetProperty<string>("lowsrc");
		}
		set
		{
			SetProperty("lowsrc", value);
		}
	}

	public int X => GetProperty<int>("x");

	public int Y => GetProperty<int>("y");

	public HTMLImageElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
