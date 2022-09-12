namespace Gecko.WebIDL;

public class PositionError : WebIDLBase
{
	public ushort Code => GetProperty<ushort>("code");

	public string Message => GetProperty<string>("message");

	public PositionError(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
