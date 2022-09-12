namespace Gecko.WebIDL;

public class IDBRequest : WebIDLBase
{
	public object Result => GetProperty<object>("result");

	public nsISupports Error => GetProperty<nsISupports>("error");

	public WebIDLUnion<nsISupports, nsISupports, nsISupports> Source => GetProperty<WebIDLUnion<nsISupports, nsISupports, nsISupports>>("source");

	public nsISupports Transaction => GetProperty<nsISupports>("transaction");

	public IDBRequestReadyState ReadyState => GetProperty<IDBRequestReadyState>("readyState");

	public IDBRequest(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
