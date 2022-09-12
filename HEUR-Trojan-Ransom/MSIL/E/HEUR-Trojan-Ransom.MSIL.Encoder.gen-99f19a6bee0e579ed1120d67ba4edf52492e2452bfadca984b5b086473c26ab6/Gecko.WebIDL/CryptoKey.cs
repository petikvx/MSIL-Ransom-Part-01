namespace Gecko.WebIDL;

public class CryptoKey : WebIDLBase
{
	public string Type => GetProperty<string>("type");

	public bool Extractable => GetProperty<bool>("extractable");

	public object Algorithm => GetProperty<object>("algorithm");

	public string[] Usages => GetProperty<string[]>("usages");

	public CryptoKey(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
