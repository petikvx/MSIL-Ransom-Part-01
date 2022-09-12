namespace Gecko.WebIDL;

public class BeforeUnloadEvent : WebIDLBase
{
	public string ReturnValue
	{
		get
		{
			return GetProperty<string>("returnValue");
		}
		set
		{
			SetProperty("returnValue", value);
		}
	}

	public BeforeUnloadEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
