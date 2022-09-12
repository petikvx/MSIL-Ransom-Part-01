namespace Gecko.WebIDL;

public class HTMLModElement : WebIDLBase
{
	public string Cite
	{
		get
		{
			return GetProperty<string>("cite");
		}
		set
		{
			SetProperty("cite", value);
		}
	}

	public string DateTime
	{
		get
		{
			return GetProperty<string>("dateTime");
		}
		set
		{
			SetProperty("dateTime", value);
		}
	}

	public HTMLModElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
