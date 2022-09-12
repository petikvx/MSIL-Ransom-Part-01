namespace Gecko.WebIDL;

public class SVGScriptElement : WebIDLBase
{
	public string Type
	{
		get
		{
			return GetProperty<string>("type");
		}
		set
		{
			SetProperty("type", value);
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

	public SVGScriptElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
