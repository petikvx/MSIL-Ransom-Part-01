namespace Gecko.WebIDL;

public class InputPortManager : WebIDLBase
{
	public InputPortManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports[]> GetInputPorts()
	{
		return CallMethod<Promise<nsISupports[]>>("getInputPorts", new object[0]);
	}
}
