namespace Gecko.WebIDL;

public class HTMLTimeElement : WebIDLBase
{
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

	public HTMLTimeElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
