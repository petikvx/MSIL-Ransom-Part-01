namespace Gecko.WebIDL;

public class IDBKeyRange : WebIDLBase
{
	public object Lower => GetProperty<object>("lower");

	public object Upper => GetProperty<object>("upper");

	public bool LowerOpen => GetProperty<bool>("lowerOpen");

	public bool UpperOpen => GetProperty<bool>("upperOpen");

	public IDBKeyRange(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
