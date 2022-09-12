namespace Gecko.WebIDL;

public class HTMLTableSectionElement : WebIDLBase
{
	public nsISupports Rows => GetProperty<nsISupports>("rows");

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

	public HTMLTableSectionElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports InsertRow()
	{
		return CallMethod<nsISupports>("insertRow", new object[0]);
	}

	public nsISupports InsertRow(int index)
	{
		return CallMethod<nsISupports>("insertRow", new object[1] { index });
	}

	public void DeleteRow(int index)
	{
		CallVoidMethod("deleteRow", index);
	}
}
