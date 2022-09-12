namespace Gecko.WebIDL;

public class EngineeringMode : WebIDLBase
{
	public EngineeringMode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<string> GetValue(string name)
	{
		return CallMethod<Promise<string>>("getValue", new object[1] { name });
	}

	public Promise SetValue(string name, string value)
	{
		return CallMethod<Promise>("setValue", new object[2] { name, value });
	}
}
