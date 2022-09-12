namespace Gecko.WebIDL;

public class MozInterAppConnection : WebIDLBase
{
	public string Keyword => GetProperty<string>("keyword");

	public string Publisher => GetProperty<string>("publisher");

	public string Subscriber => GetProperty<string>("subscriber");

	public MozInterAppConnection(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Cancel()
	{
		CallVoidMethod("cancel");
	}
}
