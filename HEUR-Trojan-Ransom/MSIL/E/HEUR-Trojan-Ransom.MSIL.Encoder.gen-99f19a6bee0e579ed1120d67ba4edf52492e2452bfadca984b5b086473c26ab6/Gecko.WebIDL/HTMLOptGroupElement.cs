namespace Gecko.WebIDL;

public class HTMLOptGroupElement : WebIDLBase
{
	public bool Disabled
	{
		get
		{
			return GetProperty<bool>("disabled");
		}
		set
		{
			SetProperty("disabled", value);
		}
	}

	public string Label
	{
		get
		{
			return GetProperty<string>("label");
		}
		set
		{
			SetProperty("label", value);
		}
	}

	public HTMLOptGroupElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
