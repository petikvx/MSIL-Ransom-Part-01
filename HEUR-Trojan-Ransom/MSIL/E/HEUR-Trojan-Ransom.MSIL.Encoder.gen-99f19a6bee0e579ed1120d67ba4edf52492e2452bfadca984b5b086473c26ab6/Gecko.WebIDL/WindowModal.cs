namespace Gecko.WebIDL;

public class WindowModal : WebIDLBase
{
	public object DialogArguments => GetProperty<object>("dialogArguments");

	public object ReturnValue
	{
		get
		{
			return GetProperty<object>("returnValue");
		}
		set
		{
			SetProperty("returnValue", value);
		}
	}

	public WindowModal(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
