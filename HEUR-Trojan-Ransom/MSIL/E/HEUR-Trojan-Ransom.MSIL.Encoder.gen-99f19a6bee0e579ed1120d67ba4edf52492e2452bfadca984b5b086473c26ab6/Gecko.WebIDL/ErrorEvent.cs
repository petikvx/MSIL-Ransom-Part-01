namespace Gecko.WebIDL;

public class ErrorEvent : WebIDLBase
{
	public string Message => GetProperty<string>("message");

	public string Filename => GetProperty<string>("filename");

	public uint Lineno => GetProperty<uint>("lineno");

	public uint Colno => GetProperty<uint>("colno");

	public object Error => GetProperty<object>("error");

	public ErrorEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
