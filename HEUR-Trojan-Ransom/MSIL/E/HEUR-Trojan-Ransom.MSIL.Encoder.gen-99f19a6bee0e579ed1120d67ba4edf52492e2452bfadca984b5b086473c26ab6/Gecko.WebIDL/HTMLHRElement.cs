namespace Gecko.WebIDL;

public class HTMLHRElement : WebIDLBase
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

	public string Color
	{
		get
		{
			return GetProperty<string>("color");
		}
		set
		{
			SetProperty("color", value);
		}
	}

	public bool NoShade
	{
		get
		{
			return GetProperty<bool>("noShade");
		}
		set
		{
			SetProperty("noShade", value);
		}
	}

	public string Size
	{
		get
		{
			return GetProperty<string>("size");
		}
		set
		{
			SetProperty("size", value);
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

	public HTMLHRElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
