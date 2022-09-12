namespace Gecko.WebIDL;

public class PositionSensorVRDevice : WebIDLBase
{
	public PositionSensorVRDevice(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetState()
	{
		return CallMethod<nsISupports>("getState", new object[0]);
	}

	public nsISupports GetImmediateState()
	{
		return CallMethod<nsISupports>("getImmediateState", new object[0]);
	}

	public void ResetSensor()
	{
		CallVoidMethod("resetSensor");
	}
}
