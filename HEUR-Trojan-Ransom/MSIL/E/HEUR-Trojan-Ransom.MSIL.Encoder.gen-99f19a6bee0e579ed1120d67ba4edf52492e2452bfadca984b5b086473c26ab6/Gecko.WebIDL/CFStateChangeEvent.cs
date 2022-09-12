namespace Gecko.WebIDL;

public class CFStateChangeEvent : WebIDLBase
{
	public ushort Action => GetProperty<ushort>("action");

	public ushort Reason => GetProperty<ushort>("reason");

	public string Number => GetProperty<string>("number");

	public ushort TimeSeconds => GetProperty<ushort>("timeSeconds");

	public ushort ServiceClass => GetProperty<ushort>("serviceClass");

	public CFStateChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
