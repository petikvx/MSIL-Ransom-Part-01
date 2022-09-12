namespace Gecko.WebIDL;

public class DOMRequestShared : WebIDLBase
{
	public DOMRequestReadyState ReadyState => GetProperty<DOMRequestReadyState>("readyState");

	public object Result => GetProperty<object>("result");

	public nsISupports Error => GetProperty<nsISupports>("error");

	public DOMRequestShared(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
