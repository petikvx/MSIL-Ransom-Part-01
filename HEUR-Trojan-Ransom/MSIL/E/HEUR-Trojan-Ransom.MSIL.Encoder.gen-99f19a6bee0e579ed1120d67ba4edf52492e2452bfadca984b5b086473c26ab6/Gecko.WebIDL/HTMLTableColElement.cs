namespace Gecko.WebIDL;

public class HTMLTableColElement : WebIDLBase
{
	public uint Span
	{
		get
		{
			return GetProperty<uint>("span");
		}
		set
		{
			SetProperty("span", value);
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

	public HTMLTableColElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
