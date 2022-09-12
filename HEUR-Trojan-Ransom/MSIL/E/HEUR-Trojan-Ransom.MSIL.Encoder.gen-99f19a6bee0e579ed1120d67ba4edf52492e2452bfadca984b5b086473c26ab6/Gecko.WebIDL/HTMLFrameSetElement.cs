namespace Gecko.WebIDL;

public class HTMLFrameSetElement : WebIDLBase
{
	public string Cols
	{
		get
		{
			return GetProperty<string>("cols");
		}
		set
		{
			SetProperty("cols", value);
		}
	}

	public string Rows
	{
		get
		{
			return GetProperty<string>("rows");
		}
		set
		{
			SetProperty("rows", value);
		}
	}

	public HTMLFrameSetElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
