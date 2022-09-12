namespace Gecko.WebIDL;

public class SEReader : WebIDLBase
{
	public bool IsSEPresent => GetProperty<bool>("isSEPresent");

	public SEType Type => GetProperty<SEType>("type");

	public SEReader(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> OpenSession()
	{
		return CallMethod<Promise<nsISupports>>("openSession", new object[0]);
	}

	public Promise CloseAll()
	{
		return CallMethod<Promise>("closeAll", new object[0]);
	}
}
