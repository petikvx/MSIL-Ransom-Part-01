namespace Gecko.WebIDL;

public class HTMLFontElement : WebIDLBase
{
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

	public string Face
	{
		get
		{
			return GetProperty<string>("face");
		}
		set
		{
			SetProperty("face", value);
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

	public HTMLFontElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
