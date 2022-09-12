namespace Gecko.WebIDL;

public class BluetoothPairingHandle : WebIDLBase
{
	public string Passkey => GetProperty<string>("passkey");

	public BluetoothPairingHandle(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise SetPinCode(string aPinCode)
	{
		return CallMethod<Promise>("setPinCode", new object[1] { aPinCode });
	}

	public Promise Accept()
	{
		return CallMethod<Promise>("accept", new object[0]);
	}

	public Promise Reject()
	{
		return CallMethod<Promise>("reject", new object[0]);
	}
}
