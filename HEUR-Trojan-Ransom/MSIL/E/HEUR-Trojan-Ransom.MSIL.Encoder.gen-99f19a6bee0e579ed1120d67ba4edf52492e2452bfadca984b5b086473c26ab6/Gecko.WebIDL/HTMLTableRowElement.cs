namespace Gecko.WebIDL;

public class HTMLTableRowElement : WebIDLBase
{
	public int RowIndex => GetProperty<int>("rowIndex");

	public int SectionRowIndex => GetProperty<int>("sectionRowIndex");

	public nsISupports Cells => GetProperty<nsISupports>("cells");

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

	public HTMLTableRowElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports InsertCell()
	{
		return CallMethod<nsISupports>("insertCell", new object[0]);
	}

	public nsISupports InsertCell(int index)
	{
		return CallMethod<nsISupports>("insertCell", new object[1] { index });
	}

	public void DeleteCell(int index)
	{
		CallVoidMethod("deleteCell", index);
	}
}
