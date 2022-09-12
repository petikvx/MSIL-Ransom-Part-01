namespace Gecko.WebIDL;

public class IDBFactory : WebIDLBase
{
	public IDBFactory(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Open(string name, ulong version)
	{
		return CallMethod<nsISupports>("open", new object[2] { name, version });
	}

	public nsISupports Open(string name)
	{
		return CallMethod<nsISupports>("open", new object[1] { name });
	}

	public nsISupports Open(string name, object options)
	{
		return CallMethod<nsISupports>("open", new object[2] { name, options });
	}

	public nsISupports DeleteDatabase(string name)
	{
		return CallMethod<nsISupports>("deleteDatabase", new object[1] { name });
	}

	public nsISupports DeleteDatabase(string name, object options)
	{
		return CallMethod<nsISupports>("deleteDatabase", new object[2] { name, options });
	}

	public short Cmp(object first, object second)
	{
		return CallMethod<short>("cmp", new object[2] { first, second });
	}

	public nsISupports OpenForPrincipal(nsISupports principal, string name, ulong version)
	{
		return CallMethod<nsISupports>("openForPrincipal", new object[3] { principal, name, version });
	}

	public nsISupports OpenForPrincipal(nsISupports principal, string name)
	{
		return CallMethod<nsISupports>("openForPrincipal", new object[2] { principal, name });
	}

	public nsISupports OpenForPrincipal(nsISupports principal, string name, object options)
	{
		return CallMethod<nsISupports>("openForPrincipal", new object[3] { principal, name, options });
	}

	public nsISupports DeleteForPrincipal(nsISupports principal, string name)
	{
		return CallMethod<nsISupports>("deleteForPrincipal", new object[2] { principal, name });
	}

	public nsISupports DeleteForPrincipal(nsISupports principal, string name, object options)
	{
		return CallMethod<nsISupports>("deleteForPrincipal", new object[3] { principal, name, options });
	}
}
