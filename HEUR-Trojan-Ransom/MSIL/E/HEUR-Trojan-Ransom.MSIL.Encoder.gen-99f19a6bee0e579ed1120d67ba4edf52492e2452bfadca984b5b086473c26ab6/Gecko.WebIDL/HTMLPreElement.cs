namespace Gecko.WebIDL;

public class HTMLPreElement : WebIDLBase
{
	public int Width
	{
		get
		{
			return GetProperty<int>("width");
		}
		set
		{
			SetProperty("width", value);
		}
	}

	public HTMLPreElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
