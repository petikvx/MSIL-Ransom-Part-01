namespace Gecko.WebIDL;

public class HTMLTableCellElement : WebIDLBase
{
	public uint ColSpan
	{
		get
		{
			return GetProperty<uint>("colSpan");
		}
		set
		{
			SetProperty("colSpan", value);
		}
	}

	public uint RowSpan
	{
		get
		{
			return GetProperty<uint>("rowSpan");
		}
		set
		{
			SetProperty("rowSpan", value);
		}
	}

	public string Headers
	{
		get
		{
			return GetProperty<string>("headers");
		}
		set
		{
			SetProperty("headers", value);
		}
	}

	public int CellIndex => GetProperty<int>("cellIndex");

	public string Abbr
	{
		get
		{
			return GetProperty<string>("abbr");
		}
		set
		{
			SetProperty("abbr", value);
		}
	}

	public string Scope
	{
		get
		{
			return GetProperty<string>("scope");
		}
		set
		{
			SetProperty("scope", value);
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

	public string Axis
	{
		get
		{
			return GetProperty<string>("axis");
		}
		set
		{
			SetProperty("axis", value);
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

	public string Ch
	{
		get
		{
			return GetProperty<string>("ch");
		}
		set
		{
			SetProperty("ch", value);
		}
	}

	public string ChOff
	{
		get
		{
			return GetProperty<string>("chOff");
		}
		set
		{
			SetProperty("chOff", value);
		}
	}

	public bool NoWrap
	{
		get
		{
			return GetProperty<bool>("noWrap");
		}
		set
		{
			SetProperty("noWrap", value);
		}
	}

	public string VAlign
	{
		get
		{
			return GetProperty<string>("vAlign");
		}
		set
		{
			SetProperty("vAlign", value);
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

	public HTMLTableCellElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
