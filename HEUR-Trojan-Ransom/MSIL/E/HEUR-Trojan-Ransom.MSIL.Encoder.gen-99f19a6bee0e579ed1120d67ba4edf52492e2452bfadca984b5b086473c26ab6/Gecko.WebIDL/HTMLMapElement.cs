namespace Gecko.WebIDL;

public class HTMLMapElement : WebIDLBase
{
	public string Name
	{
		get
		{
			return GetProperty<string>("name");
		}
		set
		{
			SetProperty("name", value);
		}
	}

	public nsISupports Areas => GetProperty<nsISupports>("areas");

	public HTMLMapElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
