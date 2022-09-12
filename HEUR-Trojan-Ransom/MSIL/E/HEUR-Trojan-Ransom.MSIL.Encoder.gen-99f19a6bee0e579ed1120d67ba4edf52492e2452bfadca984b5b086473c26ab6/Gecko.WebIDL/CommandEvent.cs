namespace Gecko.WebIDL;

public class CommandEvent : WebIDLBase
{
	public string Command => GetProperty<string>("command");

	public CommandEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitCommandEvent(string type, bool canBubble, bool cancelable, string command)
	{
		CallVoidMethod("initCommandEvent", type, canBubble, cancelable, command);
	}
}
