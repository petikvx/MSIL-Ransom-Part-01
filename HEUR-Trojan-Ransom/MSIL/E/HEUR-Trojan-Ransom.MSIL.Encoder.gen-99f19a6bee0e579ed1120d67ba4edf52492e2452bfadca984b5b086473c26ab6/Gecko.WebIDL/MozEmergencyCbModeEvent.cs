namespace Gecko.WebIDL;

public class MozEmergencyCbModeEvent : WebIDLBase
{
	public bool Active => GetProperty<bool>("active");

	public uint TimeoutMs => GetProperty<uint>("timeoutMs");

	public MozEmergencyCbModeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
