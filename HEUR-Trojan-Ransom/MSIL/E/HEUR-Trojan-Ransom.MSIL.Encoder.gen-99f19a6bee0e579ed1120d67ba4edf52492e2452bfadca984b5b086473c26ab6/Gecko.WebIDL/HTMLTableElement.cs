namespace Gecko.WebIDL;

public class HTMLTableElement : WebIDLBase
{
	public nsISupports Caption
	{
		get
		{
			return GetProperty<nsISupports>("caption");
		}
		set
		{
			SetProperty("caption", value);
		}
	}

	public nsISupports THead
	{
		get
		{
			return GetProperty<nsISupports>("tHead");
		}
		set
		{
			SetProperty("tHead", value);
		}
	}

	public nsISupports TFoot
	{
		get
		{
			return GetProperty<nsISupports>("tFoot");
		}
		set
		{
			SetProperty("tFoot", value);
		}
	}

	public nsISupports TBodies => GetProperty<nsISupports>("tBodies");

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

	public string Frame
	{
		get
		{
			return GetProperty<string>("frame");
		}
		set
		{
			SetProperty("frame", value);
		}
	}

	public string Rules
	{
		get
		{
			return GetProperty<string>("rules");
		}
		set
		{
			SetProperty("rules", value);
		}
	}

	public string Summary
	{
		get
		{
			return GetProperty<string>("summary");
		}
		set
		{
			SetProperty("summary", value);
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

	public string CellPadding
	{
		get
		{
			return GetProperty<string>("cellPadding");
		}
		set
		{
			SetProperty("cellPadding", value);
		}
	}

	public string CellSpacing
	{
		get
		{
			return GetProperty<string>("cellSpacing");
		}
		set
		{
			SetProperty("cellSpacing", value);
		}
	}

	public HTMLTableElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports CreateCaption()
	{
		return CallMethod<nsISupports>("createCaption", new object[0]);
	}

	public void DeleteCaption()
	{
		CallVoidMethod("deleteCaption");
	}

	public nsISupports CreateTHead()
	{
		return CallMethod<nsISupports>("createTHead", new object[0]);
	}

	public void DeleteTHead()
	{
		CallVoidMethod("deleteTHead");
	}

	public nsISupports CreateTFoot()
	{
		return CallMethod<nsISupports>("createTFoot", new object[0]);
	}

	public void DeleteTFoot()
	{
		CallVoidMethod("deleteTFoot");
	}

	public nsISupports CreateTBody()
	{
		return CallMethod<nsISupports>("createTBody", new object[0]);
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
